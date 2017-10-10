﻿namespace TrackingTool.Services.Contracts
{
    using System;
    using System.Linq;
    using TrackingTool.Models;

    interface IProcessesServices
    {
        IQueryable<MyProcess> GetAll();
        IQueryable<MyProcess> GetTop(int count);
        MyProcess GetById(int id);
        MyProcess GetByName(string name);
        void DeleteEntry(MyProcess process);
        MyProcess UpdateStartDate(MyProcess process, DateTime date);
        void UpdateMinutes(MyProcess process, double minutes);
        void CreateEntry(MyProcess process);
        void Create(string name);
        bool HasProcess(string name);
    }
}