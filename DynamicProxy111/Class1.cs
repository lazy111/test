using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using FluentValidation.Internal;

namespace DynamicProxy111
{
    public class iBitautoValidator<T> : AbstractValidator<T>
    {
        private ParallelMode _parallelMode = ParallelMode.Continue;
        public ParallelMode ParallelMode
        {
            get { return _parallelMode; }
            set { _parallelMode = value; }
        }


        public override FluentValidation.Results.ValidationResult Validate(ValidationContext<T> context)
        {


            if (_parallelMode == ParallelMode.Continue)
            {
                return base.Validate(context);
            }

            IEnumerator<IValidationRule> validators = base.GetEnumerator();
            IList<ValidationFailure> failures = new List<ValidationFailure>();
            while (validators.MoveNext())
            {
                string name = ((FluentValidation.Internal.PropertyRule)(validators.Current)).PropertyName;



                

                if (failures.Where(fail => fail.PropertyName == name).FirstOrDefault() == null)
                {
                    IEnumerable<ValidationFailure> vrs = validators.Current.Validate(context);
                    vrs.ToList().ForEach(item => {
                        failures.Add(item);
                    });
                }
            }
            return new ValidationResult(failures);
        }
    }

    public enum ParallelMode
    {
        Continue = 0,
        StopOnFirstFailure = 1
    }

}
