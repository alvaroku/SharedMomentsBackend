 
  delete FROM [SharedMoments].[dbo].[Actions]
    delete FROM [SharedMoments].[dbo].[Albums]
      delete FROM [SharedMoments].[dbo].[AlbumUsers]
        delete FROM [SharedMoments].[dbo].[ModuleActions]
          delete FROM [SharedMoments].[dbo].[Modules]
            delete FROM [SharedMoments].[dbo].[MomentResources]
              delete FROM [SharedMoments].[dbo].[Moments]
            delete FROM [SharedMoments].[dbo].[MomentUsers]
              delete FROM [SharedMoments].[dbo].[Permissions]
                delete FROM [SharedMoments].[dbo].[Resources]
                  delete FROM [SharedMoments].[dbo].[RolePermissions]
                    delete FROM [SharedMoments].[dbo].[Roles]
                          delete FROM [SharedMoments].[dbo].[UserFriends]
                      delete FROM [SharedMoments].[dbo].[Users]

 
