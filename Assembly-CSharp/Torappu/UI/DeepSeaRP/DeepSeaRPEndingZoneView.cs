using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005164 RID: 20836
	[Token(Token = "0x2005164")]
	public class DeepSeaRPEndingZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170047B3 RID: 18355
		// (get) Token: 0x0601EC94 RID: 126100 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EC95 RID: 126101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047B3")]
		public Action<string> onZoneClicked
		{
			[Token(Token = "0x601EC94")]
			[Address(RVA = "0x1869190", Offset = "0x1867D90", VA = "0x181869190")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601EC95")]
			[Address(RVA = "0x1869250", Offset = "0x1867E50", VA = "0x181869250")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170047B4 RID: 18356
		// (get) Token: 0x0601EC96 RID: 126102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047B4")]
		public string zoneId
		{
			[Token(Token = "0x601EC96")]
			[Address(RVA = "0x18691F0", Offset = "0x1867DF0", VA = "0x1818691F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EC97 RID: 126103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC97")]
		[Address(RVA = "0x1868D70", Offset = "0x1867970", VA = "0x181868D70")]
		public void Render(DeepSeaRPZoneMapModel model, bool isSelected)
		{
		}

		// Token: 0x0601EC98 RID: 126104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC98")]
		[Address(RVA = "0x1868C40", Offset = "0x1867840", VA = "0x181868C40")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0601EC99 RID: 126105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC99")]
		[Address(RVA = "0x1869130", Offset = "0x1867D30", VA = "0x181869130")]
		public DeepSeaRPEndingZoneView()
		{
		}

		// Token: 0x04029467 RID: 169063
		[Token(Token = "0x4029467")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _needShowLockMask;

		// Token: 0x04029468 RID: 169064
		[Token(Token = "0x4029468")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtZoneNameNormal;

		// Token: 0x04029469 RID: 169065
		[Token(Token = "0x4029469")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtZoneNameSelect;

		// Token: 0x0402946A RID: 169066
		[Token(Token = "0x402946A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _btnClickArea;

		// Token: 0x0402946B RID: 169067
		[Token(Token = "0x402946B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objNormPart;

		// Token: 0x0402946C RID: 169068
		[Token(Token = "0x402946C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objSelectPart;

		// Token: 0x0402946D RID: 169069
		[Token(Token = "0x402946D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objInfoPart;

		// Token: 0x0402946E RID: 169070
		[Token(Token = "0x402946E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtInfo;

		// Token: 0x04029470 RID: 169072
		[Token(Token = "0x4029470")]
		[FieldOffset(Offset = "0x60")]
		private string m_zoneId;

		// Token: 0x04029471 RID: 169073
		[Token(Token = "0x4029471")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onZoneClicked;

		// Token: 0x04029472 RID: 169074
		[Token(Token = "0x4029472")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onZoneClicked;

		// Token: 0x04029473 RID: 169075
		[Token(Token = "0x4029473")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x04029474 RID: 169076
		[Token(Token = "0x4029474")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029475 RID: 169077
		[Token(Token = "0x4029475")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04029476 RID: 169078
		[Token(Token = "0x4029476")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
