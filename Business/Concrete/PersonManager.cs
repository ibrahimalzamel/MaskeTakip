﻿using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
        }

        public List<Person> GetAll()
        {
            return new List<Person>();
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(
                        person.NationalIdentity,
                        person.FirstName,
                        person.LastName,
                        person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}