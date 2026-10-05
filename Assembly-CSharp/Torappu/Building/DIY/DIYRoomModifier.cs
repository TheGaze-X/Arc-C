using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x02001885 RID: 6277
	[Token(Token = "0x2001885")]
	public class DIYRoomModifier
	{
		// Token: 0x06009ED4 RID: 40660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ED4")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
		public void SetListener(DIYRoomModifier.IListener listener)
		{
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06009ED5 RID: 40661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011D5")]
		public IDIYRoomModifierData data
		{
			[Token(Token = "0x6009ED5")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06009ED6 RID: 40662 RVA: 0x0003DF50 File Offset: 0x0003C150
		// (set) Token: 0x06009ED7 RID: 40663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011D6")]
		public int roomIndex
		{
			[Token(Token = "0x6009ED6")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6009ED7")]
			[Address(RVA = "0x31900E0", Offset = "0x318ECE0", VA = "0x1831900E0")]
			set
			{
			}
		}

		// Token: 0x06009ED8 RID: 40664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ED8")]
		[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
		public DIYRoomModifier(IDIYRoomModifierData data)
		{
		}

		// Token: 0x0400959A RID: 38298
		[Token(Token = "0x400959A")]
		[FieldOffset(Offset = "0x10")]
		private DIYRoomModifier.IListener m_listener;

		// Token: 0x0400959B RID: 38299
		[Token(Token = "0x400959B")]
		[FieldOffset(Offset = "0x18")]
		private IDIYRoomModifierData m_data;

		// Token: 0x0400959C RID: 38300
		[Token(Token = "0x400959C")]
		[FieldOffset(Offset = "0x20")]
		private int m_roomIndex;

		// Token: 0x02001886 RID: 6278
		[Token(Token = "0x2001886")]
		public interface IListener
		{
			// Token: 0x06009ED9 RID: 40665
			[Token(Token = "0x6009ED9")]
			void OnDIYRoomModifierRoomIndexChanged(int oldIndex, DIYRoomModifier modifier);
		}
	}
}
