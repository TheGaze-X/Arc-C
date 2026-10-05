using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003235 RID: 12853
	[Token(Token = "0x2003235")]
	public class LineEffectEmitter : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x06014617 RID: 83479 RVA: 0x00086A00 File Offset: 0x00084C00
		[Token(Token = "0x1700303B")]
		private bool hasStartEffect
		{
			[Token(Token = "0x6014617")]
			[Address(RVA = "0xCA4EE0", Offset = "0xCA3AE0", VA = "0x180CA4EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x06014618 RID: 83480 RVA: 0x00086A18 File Offset: 0x00084C18
		[Token(Token = "0x1700303C")]
		private bool hasMidEffect
		{
			[Token(Token = "0x6014618")]
			[Address(RVA = "0xCA4E70", Offset = "0xCA3A70", VA = "0x180CA4E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x06014619 RID: 83481 RVA: 0x00086A30 File Offset: 0x00084C30
		[Token(Token = "0x1700303D")]
		private bool hasEndEffect
		{
			[Token(Token = "0x6014619")]
			[Address(RVA = "0xCA4E00", Offset = "0xCA3A00", VA = "0x180CA4E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x0601461A RID: 83482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700303E")]
		private Effect startEffect
		{
			[Token(Token = "0x601461A")]
			[Address(RVA = "0xCA4F50", Offset = "0xCA3B50", VA = "0x180CA4F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x0601461B RID: 83483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700303F")]
		private Effect endEffect
		{
			[Token(Token = "0x601461B")]
			[Address(RVA = "0xCA4CC0", Offset = "0xCA38C0", VA = "0x180CA4CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601461C RID: 83484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601461C")]
		[Address(RVA = "0xCA3A50", Offset = "0xCA2650", VA = "0x180CA3A50", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x0601461D RID: 83485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601461D")]
		[Address(RVA = "0xCA3D70", Offset = "0xCA2970", VA = "0x180CA3D70")]
		private void Update()
		{
		}

		// Token: 0x0601461E RID: 83486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601461E")]
		[Address(RVA = "0xCA4200", Offset = "0xCA2E00", VA = "0x180CA4200")]
		private void _TryUpdateEffects()
		{
		}

		// Token: 0x0601461F RID: 83487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601461F")]
		[Address(RVA = "0xCA3DD0", Offset = "0xCA29D0", VA = "0x180CA3DD0")]
		private void _RefreshMidPositions()
		{
		}

		// Token: 0x06014620 RID: 83488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014620")]
		[Address(RVA = "0xCA38F0", Offset = "0xCA24F0", VA = "0x180CA38F0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014621 RID: 83489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014621")]
		[Address(RVA = "0xCA3720", Offset = "0xCA2320", VA = "0x180CA3720", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014622 RID: 83490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014622")]
		[Address(RVA = "0xCA36C0", Offset = "0xCA22C0", VA = "0x180CA36C0", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x06014623 RID: 83491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014623")]
		[Address(RVA = "0xCA4C00", Offset = "0xCA3800", VA = "0x180CA4C00")]
		public LineEffectEmitter()
		{
		}

		// Token: 0x06014624 RID: 83492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014624")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x06014625 RID: 83493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014625")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040180D0 RID: 98512
		[Token(Token = "0x40180D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _startEffect;

		// Token: 0x040180D1 RID: 98513
		[Token(Token = "0x40180D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _midEffect;

		// Token: 0x040180D2 RID: 98514
		[Token(Token = "0x40180D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _endEffect;

		// Token: 0x040180D3 RID: 98515
		[Token(Token = "0x40180D3")]
		[FieldOffset(Offset = "0x38")]
		private LineRenderer m_lineRenderer;

		// Token: 0x040180D4 RID: 98516
		[Token(Token = "0x40180D4")]
		[FieldOffset(Offset = "0x40")]
		private ObjectPtr<Effect> m_startEffect;

		// Token: 0x040180D5 RID: 98517
		[Token(Token = "0x40180D5")]
		[FieldOffset(Offset = "0x50")]
		private ObjectPtr<Effect> m_endEffect;

		// Token: 0x040180D6 RID: 98518
		[Token(Token = "0x40180D6")]
		[FieldOffset(Offset = "0x60")]
		private List<ObjectPtr<Effect>> m_midEffects;

		// Token: 0x040180D7 RID: 98519
		[Token(Token = "0x40180D7")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_startPosition;

		// Token: 0x040180D8 RID: 98520
		[Token(Token = "0x40180D8")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 m_endPosition;

		// Token: 0x040180D9 RID: 98521
		[Token(Token = "0x40180D9")]
		[FieldOffset(Offset = "0x80")]
		private List<Vector3> m_midPositions;

		// Token: 0x040180DA RID: 98522
		[Token(Token = "0x40180DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasStartEffect;

		// Token: 0x040180DB RID: 98523
		[Token(Token = "0x40180DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasMidEffect;

		// Token: 0x040180DC RID: 98524
		[Token(Token = "0x40180DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasEndEffect;

		// Token: 0x040180DD RID: 98525
		[Token(Token = "0x40180DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_startEffect;

		// Token: 0x040180DE RID: 98526
		[Token(Token = "0x40180DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_endEffect;

		// Token: 0x040180DF RID: 98527
		[Token(Token = "0x40180DF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040180E0 RID: 98528
		[Token(Token = "0x40180E0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040180E1 RID: 98529
		[Token(Token = "0x40180E1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryUpdateEffects;

		// Token: 0x040180E2 RID: 98530
		[Token(Token = "0x40180E2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshMidPositions;

		// Token: 0x040180E3 RID: 98531
		[Token(Token = "0x40180E3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040180E4 RID: 98532
		[Token(Token = "0x40180E4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040180E5 RID: 98533
		[Token(Token = "0x40180E5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x040180E6 RID: 98534
		[Token(Token = "0x40180E6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
