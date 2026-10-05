using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069F1 RID: 27121
	[Token(Token = "0x20069F1")]
	public abstract class ZoneRecordRewardBuffPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026C86 RID: 158854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C86")]
		[Address(RVA = "0x21E2740", Offset = "0x21E1340", VA = "0x1821E2740", Slot = "4")]
		public virtual void OnRender(ZoneRewardBuffViewModel viewModel)
		{
		}

		// Token: 0x06026C87 RID: 158855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C87")]
		[Address(RVA = "0x21E2690", Offset = "0x21E1290", VA = "0x1821E2690")]
		protected GameObject InstantiatePrefab()
		{
			return null;
		}

		// Token: 0x06026C88 RID: 158856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C88")]
		[Address(RVA = "0x21E27A0", Offset = "0x21E13A0", VA = "0x1821E27A0")]
		protected ZoneRecordRewardBuffPlugin()
		{
		}

		// Token: 0x04036CB8 RID: 224440
		[Token(Token = "0x4036CB8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x04036CB9 RID: 224441
		[Token(Token = "0x4036CB9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected RectTransform _container;

		// Token: 0x04036CBA RID: 224442
		[Token(Token = "0x4036CBA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04036CBB RID: 224443
		[Token(Token = "0x4036CBB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InstantiatePrefab;

		// Token: 0x04036CBC RID: 224444
		[Token(Token = "0x4036CBC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
