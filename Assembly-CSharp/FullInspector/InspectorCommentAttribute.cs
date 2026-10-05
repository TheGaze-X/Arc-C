using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BE4 RID: 31716
	[Token(Token = "0x2007BE4")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field)]
	public class InspectorCommentAttribute : Attribute, IInspectorAttributeOrder
	{
		// Token: 0x0602C644 RID: 181828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C644")]
		[Address(RVA = "0x2861400", Offset = "0x2860000", VA = "0x182861400")]
		public InspectorCommentAttribute(string comment)
		{
		}

		// Token: 0x0602C645 RID: 181829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C645")]
		[Address(RVA = "0x2855400", Offset = "0x2854000", VA = "0x182855400")]
		public InspectorCommentAttribute(CommentType type, string comment)
		{
		}

		// Token: 0x170067F6 RID: 26614
		// (get) Token: 0x0602C646 RID: 181830 RVA: 0x000DFEF0 File Offset: 0x000DE0F0
		[Token(Token = "0x170067F6")]
		private double Order
		{
			[Token(Token = "0x602C646")]
			[Address(RVA = "0x161D230", Offset = "0x161BE30", VA = "0x18161D230", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0404027B RID: 262779
		[Token(Token = "0x404027B")]
		[FieldOffset(Offset = "0x10")]
		public string Comment;

		// Token: 0x0404027C RID: 262780
		[Token(Token = "0x404027C")]
		[FieldOffset(Offset = "0x18")]
		public CommentType Type;

		// Token: 0x0404027D RID: 262781
		[Token(Token = "0x404027D")]
		[FieldOffset(Offset = "0x20")]
		public double Order;
	}
}
