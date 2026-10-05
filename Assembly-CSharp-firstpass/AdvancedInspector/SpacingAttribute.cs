using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class SpacingAttribute : Attribute, ISpacing
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000024D8 File Offset: 0x000006D8
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public int Before
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		public int After
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			set
			{
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SpacingAttribute()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x4F4D30", Offset = "0x4F3930", VA = "0x1804F4D30")]
		public SpacingAttribute(int after)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x4F4CF0", Offset = "0x4F38F0", VA = "0x1804F4CF0")]
		public SpacingAttribute(int before, int after)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "7")]
		public int GetAfter(object[] instances, object[] values)
		{
			return 0;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "8")]
		public int GetBefore(object[] instances, object[] values)
		{
			return 0;
		}

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x10")]
		private int before;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x14")]
		private int after;
	}
}
