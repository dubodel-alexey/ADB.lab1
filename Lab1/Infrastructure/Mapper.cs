using Lab1.Entities;
using Lab1.Models;

namespace Lab1.Infrastructure
{
    public static class Mapper
    {
        public static ClientModel ToModel(this Client entity)
        {
            return new ClientModel
            {
                 Id = entity.Id,
                 Birthdate = entity.Birthdate,
                 DisabilityId = entity.Disability.Id,
                 Email = entity.Email,
                 FirstName = entity.FirstName,
                 GenderId = entity.Gender.Id,
                 IndentityNo = entity.IndentityNo,
                 IssueDate = entity.IssueDate,
                 JobPosition = entity.JobPosition,
                 LastName = entity.LastName,
                 Liable = entity.Liable,
                 LocationAddress = entity.LocationAddress,
                 LocationCityId = entity.LocationCity.Id,
                 MaritalStatusId = entity.MaritalStatus.Id,
                 MobilePhoneNumber = entity.MobilePhoneNumber,
                 MonthlyIncome = entity.MonthlyIncome,
                 NationalityId = entity.Nationality.Id,
                 PassportIssuingAuthority = entity.PassportIssuingAuthority,
                 PassportNumber = entity.PassportNumber,
                 PassportSerie = entity.PassportSerie,
                 Pensioner = entity.Pensioner,
                 RegistrationAddress = entity.RegistrationAddress,
                 RegistrationCityId = entity.RegistrationCity.Id,
                 Job = entity.Work,
                 Disability = entity.Disability.Title,
                 Gender = entity.Gender.Title,
                 LocationCity = entity.LocationCity.Title,
                 MaritalStatus = entity.MaritalStatus.Title,
                 Nationality = entity.Nationality.Title,
                 RegistrationCity = entity.RegistrationCity.Title
            };
        }

        public static Client ToEntity(this ClientModel model)
        {
            return new Client
            {
                Id = model.Id,
                Birthdate = model.Birthdate,
                DisabilityId = model.DisabilityId,
                Email = model.Email,
                FirstName = model.FirstName,
                GenderId = model.GenderId,
                IndentityNo = model.IndentityNo,
                IssueDate = model.IssueDate,
                JobPosition = model.JobPosition,
                LastName = model.LastName,
                Liable = model.Liable,
                LocationAddress = model.LocationAddress,
                LocationCityId = model.LocationCityId,
                MaritalStatusId = model.MaritalStatusId,
                MobilePhoneNumber = model.MobilePhoneNumber,
                MonthlyIncome = model.MonthlyIncome,
                NationalityId = model.NationalityId,
                PassportIssuingAuthority = model.PassportIssuingAuthority,
                PassportNumber = model.PassportNumber,
                PassportSerie = model.PassportSerie,
                Pensioner = model.Pensioner,
                RegistrationAddress = model.RegistrationAddress,
                RegistrationCityId = model.RegistrationCityId,
                Work = model.Job
            };
        }

        public static CityModel ToModel(this City entity)
        {
            return new CityModel
            {
                Id = entity.Id,
                Title = entity.Title
            };
        }

        public static GenderModel ToModel(this Gender entity)
        {
            return new GenderModel
            {
                Id = entity.Id,
                Title = entity.Title
            };
        }

        public static DisabilityModel ToModel(this Disability entity)
        {
            return new DisabilityModel
            {
                Id = entity.Id,
                Title = entity.Title
            };
        }

        public static NationalityModel ToModel(this Nationality entity)
        {
            return new NationalityModel
            {
                Id = entity.Id,
                Title = entity.Title
            };
        }

        public static MaritalStatusModel ToModel(this MaritalStatus entity)
        {
            return new MaritalStatusModel
            {
                Id = entity.Id,
                Title = entity.Title
            };
        }

        public static City ToEntity(this CityModel model)
        {
            return new City
            {
                Id = model.Id,
                Title = model.Title
            };
        }

        public static Gender ToEntity(this GenderModel model)
        {
            return new Gender
            {
                Id = model.Id,
                Title = model.Title
            };
        }

        public static Disability ToEntity(this DisabilityModel model)
        {
            return new Disability
            {
                Id = model.Id,
                Title = model.Title
            };
        }

        public static Nationality ToEntity(this NationalityModel model)
        {
            return new Nationality
            {
                Id = model.Id,
                Title = model.Title
            };
        }

        public static MaritalStatus ToEntity(this MaritalStatusModel model)
        {
            return new MaritalStatus
            {
                Id = model.Id,
                Title = model.Title
            };
        }

    }
}