﻿using JWTAuthentication.Authentication;
                // Sorting
                switch (sortColumn.ToLower())


                //if (usersQuery != null)
                //{
                //    usersQuery = usersQuery.Where(x => x.paymentStatus == paymentStatus).ToList();
                //}
                //if (usersQuery != null)
                //{
                //    usersQuery = usersQuery.Where(x => x.UserName == Username).ToList();
                //}
                if (usersQuery != null)

                // Pagination
                var totalRecords = usersQuery.Count;

                // Creating pagination metadata
                var paginationMetadata = new

                // Return results along with pagination metadata
                return Ok(new { status = true, paginationMetadata });