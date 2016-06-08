using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace DynamicProxy111
{
    class Class2 : iBitautoValidator<Student>
    {
        public Class2()
        {
            this.ParallelMode = ParallelMode.StopOnFirstFailure;
            
            RuleFor(model => model.Name).NotNull();
            RuleFor(model => model.Name).NotEmpty();
        }

    }


    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
