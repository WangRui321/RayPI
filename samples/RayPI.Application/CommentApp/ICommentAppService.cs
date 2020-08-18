﻿using System;
using Ray.Application.IAppServices;
using RayPI.AppService.CommentApp.Dtos;

namespace RayPI.AppService.CommentApp
{
    public interface ICommentAppService : ICrudAppService<CommentDto, CommentDto, Guid, QueryCommentPageDto, CommentDto, CommentDto>
    {
    }
}
