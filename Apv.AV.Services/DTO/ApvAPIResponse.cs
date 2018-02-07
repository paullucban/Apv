using System;

namespace Apv.AV.Services.DTO
{
    public class ApvAPIResponse<T>
	{
        public ApvAPIResponse(int _code, string _msg, T _data)
		{
            this.code = _code;
            this.msg = _msg;
            this.data = _data;
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
