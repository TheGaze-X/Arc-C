using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	internal class TimeFieldAttribute : PropertyAttribute
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000039A4 File Offset: 0x00001BA4
		[Token(Token = "0x170000CF")]
		public TimeFieldAttribute.UseEditMode useEditMode
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return TimeFieldAttribute.UseEditMode.None;
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x58FDAD0", Offset = "0x58FC6D0", VA = "0x1858FDAD0")]
		public TimeFieldAttribute(TimeFieldAttribute.UseEditMode useEditMode = TimeFieldAttribute.UseEditMode.ApplyEditMode)
		{
		}

		// Token: 0x02000063 RID: 99
		[Token(Token = "0x2000063")]
		public enum UseEditMode
		{
			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			None,
			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			ApplyEditMode
		}
	}
}
