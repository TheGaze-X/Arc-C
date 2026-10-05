using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200395A RID: 14682
	[Token(Token = "0x200395A")]
	public class UIStringLocatableCoordinator : UILocatableCoordinator
	{
		// Token: 0x06017332 RID: 95026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017332")]
		[Address(RVA = "0xF99DB0", Offset = "0xF989B0", VA = "0x180F99DB0")]
		public void Initialize(IUIStringLocatable locatable)
		{
		}

		// Token: 0x06017333 RID: 95027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017333")]
		[Address(RVA = "0xF99C60", Offset = "0xF98860", VA = "0x180F99C60")]
		public void Dispose()
		{
		}

		// Token: 0x06017334 RID: 95028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017334")]
		[Address(RVA = "0xF9A2C0", Offset = "0xF98EC0", VA = "0x180F9A2C0")]
		public void Register(IUIStringLocateRegistry registry)
		{
		}

		// Token: 0x06017335 RID: 95029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017335")]
		[Address(RVA = "0xF9A650", Offset = "0xF99250", VA = "0x180F9A650")]
		public void Unregister(IUIStringLocateRegistry registry)
		{
		}

		// Token: 0x06017336 RID: 95030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017336")]
		[Address(RVA = "0xF9A130", Offset = "0xF98D30", VA = "0x180F9A130")]
		public void ManualLocateTo(string identity, bool immediate)
		{
		}

		// Token: 0x06017337 RID: 95031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017337")]
		[Address(RVA = "0xF9B150", Offset = "0xF99D50", VA = "0x180F9B150")]
		private void _OnMetaChange()
		{
		}

		// Token: 0x06017338 RID: 95032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017338")]
		[Address(RVA = "0xF9AED0", Offset = "0xF99AD0", VA = "0x180F9AED0")]
		private void _OnLocatedChange(string located)
		{
		}

		// Token: 0x06017339 RID: 95033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017339")]
		[Address(RVA = "0xF9B460", Offset = "0xF9A060", VA = "0x180F9B460")]
		private void _OnRequestLocate(string target)
		{
		}

		// Token: 0x0601733A RID: 95034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601733A")]
		[Address(RVA = "0xF9B0F0", Offset = "0xF99CF0", VA = "0x180F9B0F0")]
		private void _OnLocatingComplete()
		{
		}

		// Token: 0x0601733B RID: 95035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601733B")]
		[Address(RVA = "0xF9AC40", Offset = "0xF99840", VA = "0x180F9AC40")]
		private void _ApplyLocatingState(bool locating)
		{
		}

		// Token: 0x0601733C RID: 95036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601733C")]
		[Address(RVA = "0xF9AB60", Offset = "0xF99760", VA = "0x180F9AB60")]
		private List<IUIStringLocateRegistry> _AllocateList()
		{
			return null;
		}

		// Token: 0x0601733D RID: 95037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601733D")]
		[Address(RVA = "0xF9B590", Offset = "0xF9A190", VA = "0x180F9B590")]
		private void _ReleaseList(List<IUIStringLocateRegistry> list)
		{
		}

		// Token: 0x0601733E RID: 95038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601733E")]
		[Address(RVA = "0xF9B620", Offset = "0xF9A220", VA = "0x180F9B620")]
		public UIStringLocatableCoordinator()
		{
		}

		// Token: 0x0401C001 RID: 114689
		[Token(Token = "0x401C001")]
		[FieldOffset(Offset = "0x18")]
		private IUIStringLocatable m_locatable;

		// Token: 0x0401C002 RID: 114690
		[Token(Token = "0x401C002")]
		[FieldOffset(Offset = "0x20")]
		private readonly Stack<List<IUIStringLocateRegistry>> m_observerListPool;

		// Token: 0x0401C003 RID: 114691
		[Token(Token = "0x401C003")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<string> m_toReleaseCache;

		// Token: 0x0401C004 RID: 114692
		[Token(Token = "0x401C004")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<IUIStringLocateRegistry> m_registries;

		// Token: 0x0401C005 RID: 114693
		[Token(Token = "0x401C005")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<string, List<IUIStringLocateRegistry>> m_metaObservers;

		// Token: 0x0401C006 RID: 114694
		[Token(Token = "0x401C006")]
		[FieldOffset(Offset = "0x40")]
		private string m_located;

		// Token: 0x0401C007 RID: 114695
		[Token(Token = "0x401C007")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Initialize;

		// Token: 0x0401C008 RID: 114696
		[Token(Token = "0x401C008")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401C009 RID: 114697
		[Token(Token = "0x401C009")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x0401C00A RID: 114698
		[Token(Token = "0x401C00A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Unregister;

		// Token: 0x0401C00B RID: 114699
		[Token(Token = "0x401C00B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ManualLocateTo;

		// Token: 0x0401C00C RID: 114700
		[Token(Token = "0x401C00C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnMetaChange;

		// Token: 0x0401C00D RID: 114701
		[Token(Token = "0x401C00D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnLocatedChange;

		// Token: 0x0401C00E RID: 114702
		[Token(Token = "0x401C00E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnRequestLocate;

		// Token: 0x0401C00F RID: 114703
		[Token(Token = "0x401C00F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnLocatingComplete;

		// Token: 0x0401C010 RID: 114704
		[Token(Token = "0x401C010")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ApplyLocatingState;

		// Token: 0x0401C011 RID: 114705
		[Token(Token = "0x401C011")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__AllocateList;

		// Token: 0x0401C012 RID: 114706
		[Token(Token = "0x401C012")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ReleaseList;

		// Token: 0x0401C013 RID: 114707
		[Token(Token = "0x401C013")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
