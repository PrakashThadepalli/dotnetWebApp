﻿using Microsoft.EntityFrameworkCore;

namespace myWebApp.Models
{
    public class ItemContext:DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {

        }

        public DbSet<Item> Items{ get; set; }
    }
}
