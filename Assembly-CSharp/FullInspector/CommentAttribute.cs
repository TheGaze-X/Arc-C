using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BE2 RID: 31714
	[Token(Token = "0x2007BE2")]
	[Obsolete("Use [InspectorComment] instead of [Comment]")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field)]
	public class CommentAttribute : Attribute, IInspectorAttributeOrder
	{
		// Token: 0x0602C641 RID: 181825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C641")]
		[Address(RVA = "0x28553B0", Offset = "0x2853FB0", VA = "0x1828553B0")]
		public CommentAttribute(string comment)
		{
		}

		// Token: 0x0602C642 RID: 181826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C642")]
		[Address(RVA = "0x2855400", Offset = "0x2854000", VA = "0x182855400")]
		public CommentAttribute(CommentType type, string comment)
		{
		}

		// Token: 0x170067F5 RID: 26613
		// (get) Token: 0x0602C643 RID: 181827 RVA: 0x000DFED8 File Offset: 0x000DE0D8
		[Token(Token = "0x170067F5")]
		private double Order
		{
			[Token(Token = "0x602C643")]
			[Address(RVA = "0x161D230", Offset = "0x161BE30", VA = "0x18161D230", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x04040273 RID: 262771
		[Token(Token = "0x4040273")]
		[FieldOffset(Offset = "0x10")]
		public string Comment;

		// Token: 0x04040274 RID: 262772
		[Token(Token = "0x4040274")]
		[FieldOffset(Offset = "0x18")]
		public CommentType Type;

		// Token: 0x04040275 RID: 262773
		[Token(Token = "0x4040275")]
		[FieldOffset(Offset = "0x20")]
		public double Order;
	}
}
