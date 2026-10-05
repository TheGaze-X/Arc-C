using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[AttributeUsage(AttributeTargets.Class)]
	public class TrackColorAttribute : Attribute
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x17000089")]
		public Color color
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x4E6DD0", Offset = "0x4E59D0", VA = "0x1804E6DD0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x58F9D00", Offset = "0x58F8900", VA = "0x1858F9D00")]
		public TrackColorAttribute(float r, float g, float b)
		{
		}

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x10")]
		private Color m_Color;
	}
}
