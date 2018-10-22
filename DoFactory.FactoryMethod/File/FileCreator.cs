using System;

namespace DoFactory.FactoryMethod.File
{
    public class FileCreator
    {
        public File Create<TFileType>() where TFileType : File
        {
            var fileType = typeof(TFileType);

            if (fileType == typeof(Pdf))
                return new Pdf();
            if (fileType == typeof(Html))
                return new Html();

            throw new NotImplementedException("unsupported file type");
        }
    }
}
