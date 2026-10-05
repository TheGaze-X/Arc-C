using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006525 RID: 25893
	[Token(Token = "0x2006525")]
	public class ArtMagazineCoverLeafItemViewModel : IHotfixable, IComparable<ArtMagazineCoverLeafItemViewModel>
	{
		// Token: 0x170057D6 RID: 22486
		// (get) Token: 0x06025372 RID: 152434 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025373 RID: 152435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057D6")]
		public string leafId
		{
			[Token(Token = "0x6025372")]
			[Address(RVA = "0x202DBB0", Offset = "0x202C7B0", VA = "0x18202DBB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025373")]
			[Address(RVA = "0x202DCF0", Offset = "0x202C8F0", VA = "0x18202DCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057D7 RID: 22487
		// (get) Token: 0x06025374 RID: 152436 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025375 RID: 152437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057D7")]
		public string leafEngName
		{
			[Token(Token = "0x6025374")]
			[Address(RVA = "0x202DB50", Offset = "0x202C750", VA = "0x18202DB50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025375")]
			[Address(RVA = "0x202DC70", Offset = "0x202C870", VA = "0x18202DC70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057D8 RID: 22488
		// (get) Token: 0x06025376 RID: 152438 RVA: 0x000C70C8 File Offset: 0x000C52C8
		[Token(Token = "0x170057D8")]
		public bool isEmpty
		{
			[Token(Token = "0x6025376")]
			[Address(RVA = "0x202DAA0", Offset = "0x202C6A0", VA = "0x18202DAA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170057D9 RID: 22489
		// (get) Token: 0x06025377 RID: 152439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170057D9")]
		public ArtMagazineLeafViewModel leafViewModel
		{
			[Token(Token = "0x6025377")]
			[Address(RVA = "0x202DC10", Offset = "0x202C810", VA = "0x18202DC10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025378 RID: 152440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025378")]
		[Address(RVA = "0x202D850", Offset = "0x202C450", VA = "0x18202D850")]
		public void LoadData(int index, string playerNickName)
		{
		}

		// Token: 0x06025379 RID: 152441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025379")]
		[Address(RVA = "0x202D900", Offset = "0x202C500", VA = "0x18202D900")]
		public void RefreshData(string leafId)
		{
		}

		// Token: 0x0602537A RID: 152442 RVA: 0x000C70E0 File Offset: 0x000C52E0
		[Token(Token = "0x602537A")]
		[Address(RVA = "0x202D740", Offset = "0x202C340", VA = "0x18202D740", Slot = "4")]
		public int CompareTo(ArtMagazineCoverLeafItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0602537B RID: 152443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602537B")]
		[Address(RVA = "0x202DA00", Offset = "0x202C600", VA = "0x18202DA00")]
		public ArtMagazineCoverLeafItemViewModel()
		{
		}

		// Token: 0x0403433C RID: 213820
		[Token(Token = "0x403433C")]
		[FieldOffset(Offset = "0x20")]
		private int m_index;

		// Token: 0x0403433D RID: 213821
		[Token(Token = "0x403433D")]
		[FieldOffset(Offset = "0x28")]
		private string m_nickName;

		// Token: 0x0403433E RID: 213822
		[Token(Token = "0x403433E")]
		[FieldOffset(Offset = "0x30")]
		private ArtMagazineLeafViewModel m_leafViewModel;

		// Token: 0x0403433F RID: 213823
		[Token(Token = "0x403433F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_leafId;

		// Token: 0x04034340 RID: 213824
		[Token(Token = "0x4034340")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_leafId;

		// Token: 0x04034341 RID: 213825
		[Token(Token = "0x4034341")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_leafEngName;

		// Token: 0x04034342 RID: 213826
		[Token(Token = "0x4034342")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_leafEngName;

		// Token: 0x04034343 RID: 213827
		[Token(Token = "0x4034343")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04034344 RID: 213828
		[Token(Token = "0x4034344")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_leafViewModel;

		// Token: 0x04034345 RID: 213829
		[Token(Token = "0x4034345")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034346 RID: 213830
		[Token(Token = "0x4034346")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04034347 RID: 213831
		[Token(Token = "0x4034347")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04034348 RID: 213832
		[Token(Token = "0x4034348")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
