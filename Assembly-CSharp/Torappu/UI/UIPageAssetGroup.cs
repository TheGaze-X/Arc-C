using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003620 RID: 13856
	[Token(Token = "0x2003620")]
	public class UIPageAssetGroup : IHotfixable, IDisposable, ILoadAsset
	{
		// Token: 0x0601614D RID: 90445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601614D")]
		[Address(RVA = "0xEA4380", Offset = "0xEA2F80", VA = "0x180EA4380")]
		public UIPageAssetGroup(int assetGroupId)
		{
		}

		// Token: 0x0601614E RID: 90446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601614E")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0601614F RID: 90447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601614F")]
		[Address(RVA = "0xEA41C0", Offset = "0xEA2DC0", VA = "0x180EA41C0", Slot = "6")]
		public UnityEngine.Object LoadAsset(string path)
		{
			return null;
		}

		// Token: 0x06016150 RID: 90448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016150")]
		[Address(RVA = "0xEA4250", Offset = "0xEA2E50", VA = "0x180EA4250", Slot = "7")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x06016151 RID: 90449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016151")]
		[Address(RVA = "0xEA3EC0", Offset = "0xEA2AC0", VA = "0x180EA3EC0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06016152 RID: 90450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016152")]
		private T _LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0401A861 RID: 108641
		[Token(Token = "0x401A861")]
		[FieldOffset(Offset = "0x10")]
		private int m_assetGroupId;

		// Token: 0x0401A862 RID: 108642
		[Token(Token = "0x401A862")]
		[FieldOffset(Offset = "0x14")]
		private bool m_isDisposed;

		// Token: 0x0401A863 RID: 108643
		[Token(Token = "0x401A863")]
		[FieldOffset(Offset = "0x18")]
		private ListSet<UnityEngine.Object> m_loadedAssets;

		// Token: 0x0401A864 RID: 108644
		[Token(Token = "0x401A864")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A865 RID: 108645
		[Token(Token = "0x401A865")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0401A866 RID: 108646
		[Token(Token = "0x401A866")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_LoadAsset;

		// Token: 0x0401A867 RID: 108647
		[Token(Token = "0x401A867")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x0401A868 RID: 108648
		[Token(Token = "0x401A868")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401A869 RID: 108649
		[Token(Token = "0x401A869")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadAsset;
	}
}
