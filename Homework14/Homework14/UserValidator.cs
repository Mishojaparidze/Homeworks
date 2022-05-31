using Homework14.Model;
using FluentValidation;

namespace Homework14
{
	public class PersonValidator : AbstractValidator<user>
	{
		public PersonValidator()
		{

			RuleFor(x => x.CreateDate! > System.DateTime.Today);
			RuleFor(x => x.FirstName).NotEmpty().WithMessage("name is empty").Length(1, 50).WithMessage("Length is not correct");
			RuleFor(x => x.LastName).NotEmpty().WithMessage("name is empty").Length(1, 50).WithMessage("Length is not correct");
			RuleFor(x => x.JobPosition).NotEmpty().WithMessage("name is empty").Length(1, 50).WithMessage("Length is not correct");
			RuleFor(x => x.Salary).LessThan(10000);
			RuleFor(x => x.WorkExperience).NotNull();
			RuleFor(x => x.PersonAddress.City).NotEmpty().WithMessage("name is empty");
			RuleFor(x => x.PersonAddress.Country).NotEmpty().WithMessage("name is empty");
			RuleFor(x => x.PersonAddress.HomeNumber).NotEmpty().WithMessage("name is empty").LessThan(999999999);
		}

	}
}
