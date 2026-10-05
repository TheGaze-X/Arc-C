using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Action
{
	// Token: 0x02002C49 RID: 11337
	[Token(Token = "0x2002C49")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class TooltipsBoxAttribute : TooltipAttribute
	{
		// Token: 0x0601323F RID: 78399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601323F")]
		[Address(RVA = "0xB42DF0", Offset = "0xB419F0", VA = "0x180B42DF0")]
		public TooltipsBoxAttribute(string tooltip)
		{
		}

		// Token: 0x06013240 RID: 78400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013240")]
		[Address(RVA = "0xB42F10", Offset = "0xB41B10", VA = "0x180B42F10")]
		public TooltipsBoxAttribute(string tooltip, string methodName)
		{
		}

		// Token: 0x06013241 RID: 78401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013241")]
		[Address(RVA = "0xB42E60", Offset = "0xB41A60", VA = "0x180B42E60")]
		public TooltipsBoxAttribute(string tooltip, string methodName, TooltipsBoxAttribute.InspectMessageType infoType)
		{
		}

		// Token: 0x040159E8 RID: 88552
		[Token(Token = "0x40159E8")]
		[FieldOffset(Offset = "0x18")]
		public string MethodName;

		// Token: 0x040159E9 RID: 88553
		[Token(Token = "0x40159E9")]
		[FieldOffset(Offset = "0x20")]
		public TooltipsBoxAttribute.InspectMessageType InfoMessageType;

		// Token: 0x02002C4A RID: 11338
		[Token(Token = "0x2002C4A")]
		public enum InspectMessageType
		{
			// Token: 0x040159EB RID: 88555
			[Token(Token = "0x40159EB")]
			None,
			// Token: 0x040159EC RID: 88556
			[Token(Token = "0x40159EC")]
			Info,
			// Token: 0x040159ED RID: 88557
			[Token(Token = "0x40159ED")]
			Warning,
			// Token: 0x040159EE RID: 88558
			[Token(Token = "0x40159EE")]
			Error
		}
	}
}
