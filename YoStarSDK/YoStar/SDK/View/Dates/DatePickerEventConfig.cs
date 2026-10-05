using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	[Serializable]
	public struct DatePickerEventConfig
	{
		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public DatePickerEvent OnDateTimeSelected;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public DatePickerEvent OnDayMouseOver;
	}
}
