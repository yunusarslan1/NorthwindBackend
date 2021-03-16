using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //----------ProductManager-------------------------
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";

        //--------- AuthManager---------------
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError ="Şifre hatalı";
        public static string SuccessFulLogin="Giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı mevcut";
        public static string UserRegistered ="Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu";
    }
}
