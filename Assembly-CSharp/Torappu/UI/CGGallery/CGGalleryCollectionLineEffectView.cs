using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02006003 RID: 24579
	[Token(Token = "0x2006003")]
	public class CGGalleryCollectionLineEffectView : MonoBehaviour, IUIIntegerLocateRegistry, IUILocateRegistry, IHotfixable
	{
		// Token: 0x170053EF RID: 21487
		// (get) Token: 0x06023870 RID: 145520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053EF")]
		public IReadOnlyCollection<int> metasObserved
		{
			[Token(Token = "0x6023870")]
			[Address(RVA = "0x1E2B910", Offset = "0x1E2A510", VA = "0x181E2B910", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023871 RID: 145521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023871")]
		[Address(RVA = "0x1E2B5D0", Offset = "0x1E2A1D0", VA = "0x181E2B5D0", Slot = "5")]
		public void OnMetaChange(int id, object meta)
		{
		}

		// Token: 0x06023872 RID: 145522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023872")]
		[Address(RVA = "0x1E2B290", Offset = "0x1E29E90", VA = "0x181E2B290", Slot = "6")]
		public void OnLocatedChange(int located)
		{
		}

		// Token: 0x06023873 RID: 145523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023873")]
		[Address(RVA = "0x1E2B2F0", Offset = "0x1E29EF0", VA = "0x181E2B2F0", Slot = "7")]
		public void OnLocatingStateChange(bool locating)
		{
		}

		// Token: 0x1400008D RID: 141
		// (add) Token: 0x06023874 RID: 145524 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06023875 RID: 145525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400008D")]
		public event Action<int> requestLocate
		{
			[Token(Token = "0x6023874")]
			[Address(RVA = "0x1E2B810", Offset = "0x1E2A410", VA = "0x181E2B810", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6023875")]
			[Address(RVA = "0x1E2B970", Offset = "0x1E2A570", VA = "0x181E2B970", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06023876 RID: 145526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023876")]
		[Address(RVA = "0x1E2B0F0", Offset = "0x1E29CF0", VA = "0x181E2B0F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06023877 RID: 145527 RVA: 0x000C1308 File Offset: 0x000BF508
		[Token(Token = "0x6023877")]
		[Address(RVA = "0x1E2B650", Offset = "0x1E2A250", VA = "0x181E2B650")]
		private float _GetPopPosition()
		{
			return 0f;
		}

		// Token: 0x06023878 RID: 145528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023878")]
		[Address(RVA = "0x1E2B6B0", Offset = "0x1E2A2B0", VA = "0x181E2B6B0")]
		private void _SetPopPosition(float position)
		{
		}

		// Token: 0x06023879 RID: 145529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023879")]
		[Address(RVA = "0x1E2B790", Offset = "0x1E2A390", VA = "0x181E2B790")]
		public CGGalleryCollectionLineEffectView()
		{
		}

		// Token: 0x0403127E RID: 201342
		[Token(Token = "0x403127E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CGGalleryCollectionLineView _lineView;

		// Token: 0x0403127F RID: 201343
		[Token(Token = "0x403127F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CGGalleryCollectionLineEffectView.LineEffectMovement[] _lineEffectMovements;

		// Token: 0x04031280 RID: 201344
		[Token(Token = "0x4031280")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _popDistance;

		// Token: 0x04031281 RID: 201345
		[Token(Token = "0x4031281")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Ease _popEase;

		// Token: 0x04031282 RID: 201346
		[Token(Token = "0x4031282")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _popDuration;

		// Token: 0x04031283 RID: 201347
		[Token(Token = "0x4031283")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _popDelay;

		// Token: 0x04031284 RID: 201348
		[Token(Token = "0x4031284")]
		[FieldOffset(Offset = "0x38")]
		private float m_popPosition;

		// Token: 0x04031285 RID: 201349
		[Token(Token = "0x4031285")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_popTween;

		// Token: 0x04031287 RID: 201351
		[Token(Token = "0x4031287")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_metasObserved;

		// Token: 0x04031288 RID: 201352
		[Token(Token = "0x4031288")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMetaChange;

		// Token: 0x04031289 RID: 201353
		[Token(Token = "0x4031289")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLocatedChange;

		// Token: 0x0403128A RID: 201354
		[Token(Token = "0x403128A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnLocatingStateChange;

		// Token: 0x0403128B RID: 201355
		[Token(Token = "0x403128B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_add_requestLocate;

		// Token: 0x0403128C RID: 201356
		[Token(Token = "0x403128C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_remove_requestLocate;

		// Token: 0x0403128D RID: 201357
		[Token(Token = "0x403128D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403128E RID: 201358
		[Token(Token = "0x403128E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetPopPosition;

		// Token: 0x0403128F RID: 201359
		[Token(Token = "0x403128F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetPopPosition;

		// Token: 0x04031290 RID: 201360
		[Token(Token = "0x4031290")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006004 RID: 24580
		[Token(Token = "0x2006004")]
		[Serializable]
		private class LineEffectMovement : IHotfixable
		{
			// Token: 0x170053F0 RID: 21488
			// (set) Token: 0x0602387A RID: 145530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053F0")]
			public float position
			{
				[Token(Token = "0x602387A")]
				[Address(RVA = "0x1E3EB90", Offset = "0x1E3D790", VA = "0x181E3EB90")]
				set
				{
				}
			}

			// Token: 0x0602387B RID: 145531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602387B")]
			[Address(RVA = "0x1E3E830", Offset = "0x1E3D430", VA = "0x181E3E830")]
			public void DestroyRuntime()
			{
			}

			// Token: 0x0602387C RID: 145532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602387C")]
			[Address(RVA = "0x1E3E900", Offset = "0x1E3D500", VA = "0x181E3E900")]
			private void _InitIfNot()
			{
			}

			// Token: 0x0602387D RID: 145533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602387D")]
			[Address(RVA = "0x1E3EB10", Offset = "0x1E3D710", VA = "0x181E3EB10")]
			public LineEffectMovement()
			{
			}

			// Token: 0x04031291 RID: 201361
			[Token(Token = "0x4031291")]
			[FieldOffset(Offset = "0x0")]
			private static readonly int TEX_ID;

			// Token: 0x04031292 RID: 201362
			[Token(Token = "0x4031292")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private RawImage _effectImage;

			// Token: 0x04031293 RID: 201363
			[Token(Token = "0x4031293")]
			[FieldOffset(Offset = "0x18")]
			private bool m_inited;

			// Token: 0x04031294 RID: 201364
			[Token(Token = "0x4031294")]
			[FieldOffset(Offset = "0x1C")]
			private Vector2 m_originOffset;

			// Token: 0x04031295 RID: 201365
			[Token(Token = "0x4031295")]
			[FieldOffset(Offset = "0x28")]
			private Material m_runtime;

			// Token: 0x04031296 RID: 201366
			[Token(Token = "0x4031296")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_position;

			// Token: 0x04031297 RID: 201367
			[Token(Token = "0x4031297")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_DestroyRuntime;

			// Token: 0x04031298 RID: 201368
			[Token(Token = "0x4031298")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x04031299 RID: 201369
			[Token(Token = "0x4031299")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
