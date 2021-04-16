using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Data
{
    /// <summary>
    /// Interface for database CRUD operation
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Create a user
        /// </summary>
        /// <returns></returns>
        void Create(UserDetails user);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <returns></returns>
        void Delete(UserDetails user);

        /// <summary>
        /// Update a user
        /// </summary>
        /// <returns></returns>
        void Update(UserDetails user);

        /// <summary>
        /// Read User
        /// </summary>
        /// <returns></returns>
        bool Read(UserDetails user);

        /// <summary>
        /// Validation of user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool ValidateUser(UserDetails user);

    }
}
