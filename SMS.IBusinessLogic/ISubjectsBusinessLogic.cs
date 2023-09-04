﻿using School.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.IBusinessLogic
{
    public interface ISubjectsBusinessLogic
    {

        public Task<SubjectsBL<Subjects>> SelectSubjectByID(int SubjectId);

        public Task<SubjectsBL<Subjects>> SelectSubjectByName(string SubjectName);

        public Task<List<SubjectsBL<Subjects>>> SelectAllSubjects();

        public Task<SubjectsBL<Subjects>> SaveSubject(SubjectsBL<Subjects> subject);

        public Task<SubjectsBL<Subjects>> DeleteSubject(int SubjectId);

        public Task<SubjectsBL<Subjects>> UpdateSubject(SubjectsBL<Subjects> Subject);
    }
}
