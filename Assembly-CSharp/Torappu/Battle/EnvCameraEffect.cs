using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002285 RID: 8837
	[Token(Token = "0x2002285")]
	public class EnvCameraEffect : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DE4D RID: 56909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE4D")]
		[Address(RVA = "0x3634A50", Offset = "0x3633650", VA = "0x183634A50", Slot = "16")]
		public override void OnEnvChanged(string status, Entity target, [Optional] Entity sourceNullable)
		{
		}

		// Token: 0x0600DE4E RID: 56910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE4E")]
		[Address(RVA = "0x36348A0", Offset = "0x36334A0", VA = "0x1836348A0")]
		private void ManageEffect(string status)
		{
		}

		// Token: 0x0600DE4F RID: 56911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE4F")]
		[Address(RVA = "0x3634800", Offset = "0x3633400", VA = "0x183634800", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600DE50 RID: 56912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE50")]
		[Address(RVA = "0x3634B00", Offset = "0x3633700", VA = "0x183634B00")]
		public EnvCameraEffect()
		{
		}

		// Token: 0x0600DE51 RID: 56913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE51")]
		[Address(RVA = "0x3634430", Offset = "0x3633030", VA = "0x183634430")]
		private void <>xLuaBaseProxy_OnEnvChanged(string P0, Entity P1, Entity P2)
		{
		}

		// Token: 0x0600DE52 RID: 56914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE52")]
		[Address(RVA = "0x550BD0", Offset = "0x54F7D0", VA = "0x180550BD0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0400F118 RID: 61720
		[Token(Token = "0x400F118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public List<string> _envStatus;

		// Token: 0x0400F119 RID: 61721
		[Token(Token = "0x400F119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public List<string> _envFinishStatus;

		// Token: 0x0400F11A RID: 61722
		[Token(Token = "0x400F11A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _cameraEffect;

		// Token: 0x0400F11B RID: 61723
		[Token(Token = "0x400F11B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CameraEffect m_cameraEffect;

		// Token: 0x0400F11C RID: 61724
		[Token(Token = "0x400F11C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F11D RID: 61725
		[Token(Token = "0x400F11D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ManageEffect;

		// Token: 0x0400F11E RID: 61726
		[Token(Token = "0x400F11E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F11F RID: 61727
		[Token(Token = "0x400F11F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
