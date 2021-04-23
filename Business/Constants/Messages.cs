using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        
        public static string ProductAdded = "Product has been added.";

        public static string CategoryAdded = "Category has been added.";

        public static string ProductNameInvalid = "Product name is invalid.";

        public static string CategoryNameInvalid = "Category name is invalid.";

        public static string MaintenanceTime = "System is under maintenance";

        public static string ProductListed = "Products have been listed.";

        public static string CategoryListed = "Categories have been listed.";

        public static string CategoryFound = "Searching category found.";

        public static string ProductDetailListed = "Products' detail have been listed.";

        public static string ProductCountOfCategoryError = "The number of products in each category should not be more than 10.";

        public static string ProductNameAlreadyExists= "There is already a product with this name.";

        public static string CategoryLimitExceeded= "Cannot add new products because category limit has been exceeded.";

        public static string UserRegistered = "User registered";

        public static string UserNotFound= "No user found";

        public static string PasswordError = "Password is wrong.";

        public static string SuccessfulLogin = " Login is successful.";

        public static string UserAlreadyExists = "User already exists. ";

        public static string AccessTokenCreated = "Access token created.";

        public static string AuthorizationDenied = "Authorization denied";

        public static string CategoryUpdated = "Category has been updated successfuly";

        public static string ProductUpdated = "Product updated successfully";

        public static string ProductDeleted = "Product deleted successfully";

        public static string CustomerAdded = "Customer added succuessfully";

        public static string CustomerDeleted = "Customer deleted successfully";

        public static string CustomerListed = "Customer listed successfully";

        public static string CustomerFound ="Customer found";

        public static string CustomerUpdated = "Customer updated";
    }
}
