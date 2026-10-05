using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RangeValueAttribute : Attribute, IListAttribute
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002400 File Offset: 0x00000600
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		public float Min
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002418 File Offset: 0x00000618
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004B")]
		public float Max
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x4F1EB0", Offset = "0x4F0AB0", VA = "0x1804F1EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x4F1EC0", Offset = "0x4F0AC0", VA = "0x1804F1EC0")]
			set
			{
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4F1E70", Offset = "0x4F0A70", VA = "0x1804F1E70")]
		public RangeValueAttribute(float min, float max)
		{
		}

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x10")]
		private float min;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x14")]
		private float max;
	}
}
