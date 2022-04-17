﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Books;

public class CreateUpdateBookDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; }
    [Required]
    public BookType Type { get; set; } = BookType.Undefined;
    [Required]
    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; }
    [Required]
    public float Price { get; set; }
}