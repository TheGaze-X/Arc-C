using System;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200283E RID: 10302
	[Token(Token = "0x200283E")]
	[AttributeUsage(AttributeTargets.Class)]
	public class NodeInfoAttribute : Attribute
	{
		// Token: 0x0601127E RID: 70270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601127E")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public NodeInfoAttribute()
		{
		}

		// Token: 0x0601127F RID: 70271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601127F")]
		[Address(RVA = "0x916A90", Offset = "0x915690", VA = "0x180916A90")]
		public NodeInfoAttribute(string category, string name, int priority)
		{
		}

		// Token: 0x04013361 RID: 78689
		[Token(Token = "0x4013361")]
		[FieldOffset(Offset = "0x10")]
		public string Category;

		// Token: 0x04013362 RID: 78690
		[Token(Token = "0x4013362")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x04013363 RID: 78691
		[Token(Token = "0x4013363")]
		[FieldOffset(Offset = "0x20")]
		public int Priority;
	}
}
