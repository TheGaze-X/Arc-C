using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003959 RID: 14681
	[Token(Token = "0x2003959")]
	public class UIIntegerLocatableCoordinator : UILocatableCoordinator
	{
		// Token: 0x06017325 RID: 95013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017325")]
		[Address(RVA = "0xF93FC0", Offset = "0xF92BC0", VA = "0x180F93FC0")]
		public void Initialize(IUIIntegerLocatable locatable)
		{
		}

		// Token: 0x06017326 RID: 95014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017326")]
		[Address(RVA = "0xF93E70", Offset = "0xF92A70", VA = "0x180F93E70")]
		public void Dispose()
		{
		}

		// Token: 0x06017327 RID: 95015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017327")]
		[Address(RVA = "0xF94460", Offset = "0xF93060", VA = "0x180F94460")]
		public void Register(IUIIntegerLocateRegistry registry)
		{
		}

		// Token: 0x06017328 RID: 95016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017328")]
		[Address(RVA = "0xF947E0", Offset = "0xF933E0", VA = "0x180F947E0")]
		public void Unregister(IUIIntegerLocateRegistry registry)
		{
		}

		// Token: 0x06017329 RID: 95017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017329")]
		[Address(RVA = "0xF942D0", Offset = "0xF92ED0", VA = "0x180F942D0")]
		public void ManualLocateTo(int identity, bool immediate)
		{
		}

		// Token: 0x0601732A RID: 95018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601732A")]
		[Address(RVA = "0xF95240", Offset = "0xF93E40", VA = "0x180F95240")]
		private void _OnMetaChange()
		{
		}

		// Token: 0x0601732B RID: 95019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601732B")]
		[Address(RVA = "0xF94FD0", Offset = "0xF93BD0", VA = "0x180F94FD0")]
		private void _OnLocatedChange(int located)
		{
		}

		// Token: 0x0601732C RID: 95020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601732C")]
		[Address(RVA = "0xF95550", Offset = "0xF94150", VA = "0x180F95550")]
		private void _OnRequestLocate(int target)
		{
		}

		// Token: 0x0601732D RID: 95021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601732D")]
		[Address(RVA = "0xF951E0", Offset = "0xF93DE0", VA = "0x180F951E0")]
		private void _OnLocatingComplete()
		{
		}

		// Token: 0x0601732E RID: 95022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601732E")]
		[Address(RVA = "0xF94D40", Offset = "0xF93940", VA = "0x180F94D40")]
		private void _ApplyLocatingState(bool locating)
		{
		}

		// Token: 0x0601732F RID: 95023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601732F")]
		[Address(RVA = "0xF94C60", Offset = "0xF93860", VA = "0x180F94C60")]
		private List<IUIIntegerLocateRegistry> _AllocateList()
		{
			return null;
		}

		// Token: 0x06017330 RID: 95024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017330")]
		[Address(RVA = "0xF95680", Offset = "0xF94280", VA = "0x180F95680")]
		private void _ReleaseList(List<IUIIntegerLocateRegistry> list)
		{
		}

		// Token: 0x06017331 RID: 95025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017331")]
		[Address(RVA = "0xF95710", Offset = "0xF94310", VA = "0x180F95710")]
		public UIIntegerLocatableCoordinator()
		{
		}

		// Token: 0x0401BFEE RID: 114670
		[Token(Token = "0x401BFEE")]
		[FieldOffset(Offset = "0x18")]
		private IUIIntegerLocatable m_locatable;

		// Token: 0x0401BFEF RID: 114671
		[Token(Token = "0x401BFEF")]
		[FieldOffset(Offset = "0x20")]
		private readonly Stack<List<IUIIntegerLocateRegistry>> m_observerListPool;

		// Token: 0x0401BFF0 RID: 114672
		[Token(Token = "0x401BFF0")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<int> m_toReleaseCache;

		// Token: 0x0401BFF1 RID: 114673
		[Token(Token = "0x401BFF1")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<IUIIntegerLocateRegistry> m_registries;

		// Token: 0x0401BFF2 RID: 114674
		[Token(Token = "0x401BFF2")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<int, List<IUIIntegerLocateRegistry>> m_metaObservers;

		// Token: 0x0401BFF3 RID: 114675
		[Token(Token = "0x401BFF3")]
		[FieldOffset(Offset = "0x40")]
		private int m_located;

		// Token: 0x0401BFF4 RID: 114676
		[Token(Token = "0x401BFF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Initialize;

		// Token: 0x0401BFF5 RID: 114677
		[Token(Token = "0x401BFF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401BFF6 RID: 114678
		[Token(Token = "0x401BFF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x0401BFF7 RID: 114679
		[Token(Token = "0x401BFF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Unregister;

		// Token: 0x0401BFF8 RID: 114680
		[Token(Token = "0x401BFF8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ManualLocateTo;

		// Token: 0x0401BFF9 RID: 114681
		[Token(Token = "0x401BFF9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnMetaChange;

		// Token: 0x0401BFFA RID: 114682
		[Token(Token = "0x401BFFA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnLocatedChange;

		// Token: 0x0401BFFB RID: 114683
		[Token(Token = "0x401BFFB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnRequestLocate;

		// Token: 0x0401BFFC RID: 114684
		[Token(Token = "0x401BFFC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnLocatingComplete;

		// Token: 0x0401BFFD RID: 114685
		[Token(Token = "0x401BFFD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ApplyLocatingState;

		// Token: 0x0401BFFE RID: 114686
		[Token(Token = "0x401BFFE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__AllocateList;

		// Token: 0x0401BFFF RID: 114687
		[Token(Token = "0x401BFFF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ReleaseList;

		// Token: 0x0401C000 RID: 114688
		[Token(Token = "0x401C000")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
