using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.DIY;
using Torappu.GraphicEffect.Reflection;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A40 RID: 6720
	[Token(Token = "0x2001A40")]
	public class VaultReflectionConfigHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x0600A894 RID: 43156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001393")]
		public DIYRoom.IRefectionMaterialFilter reflectFilter
		{
			[Token(Token = "0x600A894")]
			[Address(RVA = "0x32507C0", Offset = "0x324F3C0", VA = "0x1832507C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A895 RID: 43157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A895")]
		[Address(RVA = "0x324FA50", Offset = "0x324E650", VA = "0x18324FA50")]
		public void InitIfNot()
		{
		}

		// Token: 0x0600A896 RID: 43158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A896")]
		[Address(RVA = "0x324F800", Offset = "0x324E400", VA = "0x18324F800")]
		public ReflectCameraHolder GetReflectCameraHolder(VDIYRoom vRoom)
		{
			return null;
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A897")]
		[Address(RVA = "0x3250340", Offset = "0x324EF40", VA = "0x183250340")]
		private void _RefreshActiveCameras()
		{
		}

		// Token: 0x0600A898 RID: 43160 RVA: 0x00041520 File Offset: 0x0003F720
		[Token(Token = "0x600A898")]
		[Address(RVA = "0x324FDD0", Offset = "0x324E9D0", VA = "0x18324FDD0")]
		private int _CalculatePriority()
		{
			return 0;
		}

		// Token: 0x0600A899 RID: 43161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A899")]
		[Address(RVA = "0x3250400", Offset = "0x324F000", VA = "0x183250400")]
		private void _ReleaseLowPriorityCameras(int validPriority)
		{
		}

		// Token: 0x0600A89A RID: 43162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A89A")]
		[Address(RVA = "0x32500C0", Offset = "0x324ECC0", VA = "0x1832500C0")]
		private void _HoldFreeCameras(int validPriority)
		{
		}

		// Token: 0x0600A89B RID: 43163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A89B")]
		[Address(RVA = "0x324FCA0", Offset = "0x324E8A0", VA = "0x18324FCA0")]
		private void Update()
		{
		}

		// Token: 0x0600A89C RID: 43164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A89C")]
		[Address(RVA = "0x324FBE0", Offset = "0x324E7E0", VA = "0x18324FBE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A89D RID: 43165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A89D")]
		[Address(RVA = "0x3250620", Offset = "0x324F220", VA = "0x183250620")]
		public VaultReflectionConfigHolder()
		{
		}

		// Token: 0x0400A0B8 RID: 41144
		[Token(Token = "0x400A0B8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Used to exclude materials with certain names from reflection")]
		private string[] _reflectExcludeMaterialNames;

		// Token: 0x0400A0B9 RID: 41145
		[Token(Token = "0x400A0B9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ReflectCamera[] _reflectCameras;

		// Token: 0x0400A0BA RID: 41146
		[Token(Token = "0x400A0BA")]
		[FieldOffset(Offset = "0x28")]
		private PeriodicTicker m_idleTicker;

		// Token: 0x0400A0BB RID: 41147
		[Token(Token = "0x400A0BB")]
		[FieldOffset(Offset = "0x30")]
		private int m_cameraCount;

		// Token: 0x0400A0BC RID: 41148
		[Token(Token = "0x400A0BC")]
		[FieldOffset(Offset = "0x34")]
		private bool m_isInited;

		// Token: 0x0400A0BD RID: 41149
		[Token(Token = "0x400A0BD")]
		[FieldOffset(Offset = "0x38")]
		private VaultReflectionConfigHolder.ReflectMatFilter m_matFilter;

		// Token: 0x0400A0BE RID: 41150
		[Token(Token = "0x400A0BE")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, VaultReflectionCameraHolder> m_cameraHolders;

		// Token: 0x0400A0BF RID: 41151
		[Token(Token = "0x400A0BF")]
		[FieldOffset(Offset = "0x48")]
		private List<VaultReflectionCameraHolder> m_activeHolders;

		// Token: 0x0400A0C0 RID: 41152
		[Token(Token = "0x400A0C0")]
		[FieldOffset(Offset = "0x50")]
		private List<ReflectCamera> m_freeCameras;

		// Token: 0x0400A0C1 RID: 41153
		[Token(Token = "0x400A0C1")]
		[FieldOffset(Offset = "0x58")]
		private Heap<int> m_enabledHolderPriority;

		// Token: 0x0400A0C2 RID: 41154
		[Token(Token = "0x400A0C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_reflectFilter;

		// Token: 0x0400A0C3 RID: 41155
		[Token(Token = "0x400A0C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0400A0C4 RID: 41156
		[Token(Token = "0x400A0C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetReflectCameraHolder;

		// Token: 0x0400A0C5 RID: 41157
		[Token(Token = "0x400A0C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshActiveCameras;

		// Token: 0x0400A0C6 RID: 41158
		[Token(Token = "0x400A0C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CalculatePriority;

		// Token: 0x0400A0C7 RID: 41159
		[Token(Token = "0x400A0C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReleaseLowPriorityCameras;

		// Token: 0x0400A0C8 RID: 41160
		[Token(Token = "0x400A0C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HoldFreeCameras;

		// Token: 0x0400A0C9 RID: 41161
		[Token(Token = "0x400A0C9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400A0CA RID: 41162
		[Token(Token = "0x400A0CA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400A0CB RID: 41163
		[Token(Token = "0x400A0CB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001A41 RID: 6721
		[Token(Token = "0x2001A41")]
		private class ReflectMatFilter : DIYRoom.IRefectionMaterialFilter
		{
			// Token: 0x0600A89E RID: 43166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A89E")]
			[Address(RVA = "0x3236DF0", Offset = "0x32359F0", VA = "0x183236DF0")]
			public ReflectMatFilter(string[] excludeNames)
			{
			}

			// Token: 0x0600A89F RID: 43167 RVA: 0x00041538 File Offset: 0x0003F738
			[Token(Token = "0x600A89F")]
			[Address(RVA = "0x3236D00", Offset = "0x3235900", VA = "0x183236D00", Slot = "4")]
			public bool IsReflectable(Material mat)
			{
				return default(bool);
			}

			// Token: 0x0400A0CC RID: 41164
			[Token(Token = "0x400A0CC")]
			private const string NON_REFLECT_MAT = "_norefl";

			// Token: 0x0400A0CD RID: 41165
			[Token(Token = "0x400A0CD")]
			[FieldOffset(Offset = "0x10")]
			private List<string> m_excludeNames;
		}
	}
}
