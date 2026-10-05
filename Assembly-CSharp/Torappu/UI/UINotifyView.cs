using System;
using Il2CppDummyDll;
using Torappu.Notification;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AE7 RID: 15079
	[Token(Token = "0x2003AE7")]
	public abstract class UINotifyView : NotifyView, ILoadAsset
	{
		// Token: 0x06017C4E RID: 97358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C4E")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06017C4F RID: 97359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C4F")]
		[Address(RVA = "0x1011680", Offset = "0x1010280", VA = "0x181011680", Slot = "6")]
		public UnityEngine.Object LoadAsset(string path)
		{
			return null;
		}

		// Token: 0x06017C50 RID: 97360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C50")]
		[Address(RVA = "0x1011830", Offset = "0x1010430", VA = "0x181011830", Slot = "7")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x06017C51 RID: 97361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C51")]
		[Address(RVA = "0x1011740", Offset = "0x1010340", VA = "0x181011740")]
		private void OnDestroy()
		{
		}

		// Token: 0x06017C52 RID: 97362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C52")]
		[Address(RVA = "0x10117D0", Offset = "0x10103D0", VA = "0x1810117D0", Slot = "8")]
		protected virtual void SubClassOnDestroy()
		{
		}

		// Token: 0x06017C53 RID: 97363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C53")]
		[Address(RVA = "0x10118B0", Offset = "0x10104B0", VA = "0x1810118B0")]
		protected UINotifyView()
		{
		}

		// Token: 0x0401CB3D RID: 117565
		[Token(Token = "0x401CB3D")]
		[FieldOffset(Offset = "0x28")]
		private UIAssetLoader.Assets m_assets;

		// Token: 0x0401CB3E RID: 117566
		[Token(Token = "0x401CB3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0401CB3F RID: 117567
		[Token(Token = "0x401CB3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_LoadAsset;

		// Token: 0x0401CB40 RID: 117568
		[Token(Token = "0x401CB40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x0401CB41 RID: 117569
		[Token(Token = "0x401CB41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401CB42 RID: 117570
		[Token(Token = "0x401CB42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SubClassOnDestroy;

		// Token: 0x0401CB43 RID: 117571
		[Token(Token = "0x401CB43")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
