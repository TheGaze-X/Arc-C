using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E24 RID: 20004
	[Token(Token = "0x2004E24")]
	public class FireworkPlateElementView : MonoBehaviour, IFireworkPlateElementView, IHotfixable
	{
		// Token: 0x17004626 RID: 17958
		// (get) Token: 0x0601DE29 RID: 122409 RVA: 0x000ACA58 File Offset: 0x000AAC58
		// (set) Token: 0x0601DE2A RID: 122410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004626")]
		public GridPosition gridPos
		{
			[Token(Token = "0x601DE29")]
			[Address(RVA = "0x176A430", Offset = "0x1769030", VA = "0x18176A430", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(GridPosition);
			}
			[Token(Token = "0x601DE2A")]
			[Address(RVA = "0x176A490", Offset = "0x1769090", VA = "0x18176A490", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601DE2B RID: 122411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE2B")]
		[Address(RVA = "0x1769D70", Offset = "0x1768970", VA = "0x181769D70")]
		public void Render(FireworkPlateModel plateModel, FireworkPlateViewStyle style)
		{
		}

		// Token: 0x0601DE2C RID: 122412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE2C")]
		[Address(RVA = "0x176A3C0", Offset = "0x1768FC0", VA = "0x18176A3C0")]
		public FireworkPlateElementView()
		{
		}

		// Token: 0x04027A0F RID: 162319
		[Token(Token = "0x4027A0F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlDisabled;

		// Token: 0x04027A10 RID: 162320
		[Token(Token = "0x4027A10")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlCenter;

		// Token: 0x04027A11 RID: 162321
		[Token(Token = "0x4027A11")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlConflict;

		// Token: 0x04027A12 RID: 162322
		[Token(Token = "0x4027A12")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgBkg;

		// Token: 0x04027A13 RID: 162323
		[Token(Token = "0x4027A13")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgDisabled;

		// Token: 0x04027A14 RID: 162324
		[Token(Token = "0x4027A14")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgCenter;

		// Token: 0x04027A15 RID: 162325
		[Token(Token = "0x4027A15")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgConflict;

		// Token: 0x04027A16 RID: 162326
		[Token(Token = "0x4027A16")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x04027A17 RID: 162327
		[Token(Token = "0x4027A17")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tween;

		// Token: 0x04027A18 RID: 162328
		[Token(Token = "0x4027A18")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedLoadSeqNum;

		// Token: 0x04027A1A RID: 162330
		[Token(Token = "0x4027A1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gridPos;

		// Token: 0x04027A1B RID: 162331
		[Token(Token = "0x4027A1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_gridPos;

		// Token: 0x04027A1C RID: 162332
		[Token(Token = "0x4027A1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027A1D RID: 162333
		[Token(Token = "0x4027A1D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
