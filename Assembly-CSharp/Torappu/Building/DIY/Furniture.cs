using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x0200188F RID: 6287
	[Token(Token = "0x200188F")]
	public class Furniture
	{
		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06009EF7 RID: 40695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011E4")]
		public Furniture.IListener listener
		{
			[Token(Token = "0x6009EF7")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009EF8 RID: 40696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF8")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
		public void SetListener(Furniture.IListener listener)
		{
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06009EF9 RID: 40697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011E5")]
		public IFurnitureData data
		{
			[Token(Token = "0x6009EF9")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x06009EFA RID: 40698 RVA: 0x0003E010 File Offset: 0x0003C210
		[Token(Token = "0x170011E6")]
		public int pos0
		{
			[Token(Token = "0x6009EFA")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x06009EFB RID: 40699 RVA: 0x0003E028 File Offset: 0x0003C228
		[Token(Token = "0x170011E7")]
		public int pos1
		{
			[Token(Token = "0x6009EFB")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x06009EFC RID: 40700 RVA: 0x0003E040 File Offset: 0x0003C240
		[Token(Token = "0x170011E8")]
		public int dir
		{
			[Token(Token = "0x6009EFC")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x06009EFD RID: 40701 RVA: 0x0003E058 File Offset: 0x0003C258
		[Token(Token = "0x170011E9")]
		public bool swapXZ
		{
			[Token(Token = "0x6009EFD")]
			[Address(RVA = "0x319E8F0", Offset = "0x319D4F0", VA = "0x18319E8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06009EFE RID: 40702 RVA: 0x0003E070 File Offset: 0x0003C270
		[Token(Token = "0x170011EA")]
		public int roomIndex
		{
			[Token(Token = "0x6009EFE")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x06009EFF RID: 40703 RVA: 0x0003E088 File Offset: 0x0003C288
		[Token(Token = "0x170011EB")]
		public bool isInteractive
		{
			[Token(Token = "0x6009EFF")]
			[Address(RVA = "0x319E840", Offset = "0x319D440", VA = "0x18319E840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x06009F00 RID: 40704 RVA: 0x0003E0A0 File Offset: 0x0003C2A0
		[Token(Token = "0x170011EC")]
		public bool isMusicFurniture
		{
			[Token(Token = "0x6009F00")]
			[Address(RVA = "0x319E890", Offset = "0x319D490", VA = "0x18319E890")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009F01 RID: 40705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F01")]
		[Address(RVA = "0x319E800", Offset = "0x319D400", VA = "0x18319E800")]
		public Furniture(IFurnitureData data)
		{
		}

		// Token: 0x06009F02 RID: 40706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F02")]
		[Address(RVA = "0x319E690", Offset = "0x319D290", VA = "0x18319E690")]
		public void SetPosition(int pos0, int pos1)
		{
		}

		// Token: 0x06009F03 RID: 40707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F03")]
		[Address(RVA = "0x319E7A0", Offset = "0x319D3A0", VA = "0x18319E7A0")]
		public void SetRoomIndex(int index)
		{
		}

		// Token: 0x06009F04 RID: 40708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F04")]
		[Address(RVA = "0x319E630", Offset = "0x319D230", VA = "0x18319E630")]
		public void SetDirection(int dir)
		{
		}

		// Token: 0x040095A5 RID: 38309
		[Token(Token = "0x40095A5")]
		[FieldOffset(Offset = "0x10")]
		private Furniture.IListener m_listener;

		// Token: 0x040095A6 RID: 38310
		[Token(Token = "0x40095A6")]
		[FieldOffset(Offset = "0x18")]
		private IFurnitureData m_data;

		// Token: 0x040095A7 RID: 38311
		[Token(Token = "0x40095A7")]
		[FieldOffset(Offset = "0x20")]
		private int m_pos0;

		// Token: 0x040095A8 RID: 38312
		[Token(Token = "0x40095A8")]
		[FieldOffset(Offset = "0x24")]
		private int m_pos1;

		// Token: 0x040095A9 RID: 38313
		[Token(Token = "0x40095A9")]
		[FieldOffset(Offset = "0x28")]
		private int m_dir;

		// Token: 0x040095AA RID: 38314
		[Token(Token = "0x40095AA")]
		[FieldOffset(Offset = "0x2C")]
		private int m_roomIndex;

		// Token: 0x02001890 RID: 6288
		[Token(Token = "0x2001890")]
		public interface IListener
		{
			// Token: 0x06009F05 RID: 40709
			[Token(Token = "0x6009F05")]
			void OnFurniturePositionChanged(int oldPos0, int oldPos1, Furniture furniture);

			// Token: 0x06009F06 RID: 40710
			[Token(Token = "0x6009F06")]
			void OnFurnitureRotateChanged(int dir, Furniture furniture);

			// Token: 0x06009F07 RID: 40711
			[Token(Token = "0x6009F07")]
			void OnFurnitureRoomIndexChanged(int oldIndex, Furniture furniture);
		}
	}
}
