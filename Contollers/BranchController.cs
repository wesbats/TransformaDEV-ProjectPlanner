﻿using ProjectPlanner.Models.Classes;
using ProjectPlanner.Models.Interfaces;
using ProjectPlanner.Views;

namespace ProjectPlanner.Contollers
{
    internal class BranchController
    {
        IList<IBranch> mainBranch;

        /// <summary>
        /// Retorna a Branch principal.
        /// </summary>
        /// <returns>IList<IBranch></returns>
        internal IList<IBranch> In()
        {
            return mainBranch;
        }

        /// <summary>
        /// Cria uma nova Branch.
        /// </summary>
        internal void Add(string titleNewBranch)
        {
            mainBranch.Add(new Branch(titleNewBranch != "" ? titleNewBranch : "Branch sem título"));
            return;
        }

        /// <summary>
        /// Apaga uma Branch.
        /// </summary>
        internal void Remove()
        {

        }

        /// <summary>
        /// Retorna a quantidade de branchs registradas.
        /// </summary>
        /// <returns>int</returns>
        internal int Count()
        {
            return mainBranch.Count;
        }

        /// <summary>
        /// Solicita a o DBController salvar a Branch Principal.
        /// </summary>
        internal void Save()
        {
            DBController.Save(mainBranch);
        }
        /// <summary>
        /// Solicita ao DBController os dados salvos da Branch Principal.
        /// </summary>
        /// <returns></returns>
        internal void Load()
        {
            mainBranch = DBController.Load();
        }
    }
}
