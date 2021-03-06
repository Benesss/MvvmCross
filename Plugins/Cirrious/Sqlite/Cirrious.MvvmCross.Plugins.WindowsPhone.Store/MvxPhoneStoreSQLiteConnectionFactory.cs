// MvxStoreSQLiteConnectionFactory.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System.IO;
using Cirrious.MvvmCross.Plugins.Sqlite;
using SQLite;

namespace Cirrious.MvvmCross.Plugins.WindowsPhone.Store
{
    public class MvxPhoneStoreSQLiteConnectionFactory : ISQLiteConnectionFactory
    {
        public ISQLiteConnection Create(string address)
        {
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, address);
            return new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
        }
    }
}