using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Guestly.Models
{
  [DataContract]
	public class DataPoint
	{
		public DataPoint(double x, double y, string label)
		{
			this.X = x;
			this.Y = y;
      this.Label = label;
		}

		[DataMember(Name = "x")]
		public Nullable<double> X = null;

		[DataMember(Name = "y")]
		public Nullable<double> Y = null;	


		[DataMember(Name = "label")]
		public string Label = "";
  }

}