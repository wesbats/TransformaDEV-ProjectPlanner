﻿using ProjectPlanner.Models.Data;
using ProjectPlanner.Models.Interfaces;

namespace ProjectPlanner.Contollers
{
    internal class DBController
    {
        /// <summary>
        /// Salva a Branch principal no Json que se encontra no mesmo diretório do executável
        /// </summary>
        /// <param name="mainBranch"></param>
        internal static void Save(IList<IBranch> mainBranch)
        {
            ManagementDB.Save(mainBranch);
        }

        /// <summary>
        /// Carrega os dados salvos no Json que se encontra no mesmo diretório do executável.
        /// </summary>
        /// <returns></returns>
        internal static IList<IBranch> Load()
        {
            IList<IBranch> mainBranch = ManagementDB.Load();
            return mainBranch;
        }
    }
}
