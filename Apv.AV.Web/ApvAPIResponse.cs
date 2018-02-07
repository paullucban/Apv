using System;
namespace Apv.AV.Web
{
    public class ApvAPIResponse<T>
	{
        public ApvAPIResponse(int _code, string _msg, T _data)
		{
            this.code = _code;
            this.msg = _msg;
            this.data = data;
		}

        public int code
        {
            get;
            set;
        }

        public string msg
        {
            get;
            set;
        }

        public T data
        {
            get;
            set;
        }

	}
}
