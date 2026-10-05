using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007653 RID: 30291
	[Token(Token = "0x2007653")]
	public class Act20sideCarBlueprintView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A9C3 RID: 174531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A9C3")]
		[Address(RVA = "0x264FED0", Offset = "0x264EAD0", VA = "0x18264FED0")]
		private UIAtlasObject _EnsureAtlasObject()
		{
			return null;
		}

		// Token: 0x0602A9C4 RID: 174532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9C4")]
		[Address(RVA = "0x264FAB0", Offset = "0x264E6B0", VA = "0x18264FAB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602A9C5 RID: 174533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9C5")]
		[Address(RVA = "0x2650520", Offset = "0x264F120", VA = "0x182650520")]
		private void _UnloadCart()
		{
		}

		// Token: 0x0602A9C6 RID: 174534 RVA: 0x000D9428 File Offset: 0x000D7628
		[Token(Token = "0x602A9C6")]
		[Address(RVA = "0x264FFF0", Offset = "0x264EBF0", VA = "0x18264FFF0")]
		private SpriteRenderData _GetSpriteCart(string compId, CartComponents.CartAccessoryPos pos)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0602A9C7 RID: 174535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9C7")]
		[Address(RVA = "0x264FC00", Offset = "0x264E800", VA = "0x18264FC00")]
		public void SetPos(string selectId, CartComponents.CartAccessoryPos pos)
		{
		}

		// Token: 0x0602A9C8 RID: 174536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A9C8")]
		[Address(RVA = "0x2650260", Offset = "0x264EE60", VA = "0x182650260")]
		private Sequence _GetTweenSeq(Vector3 pos)
		{
			return null;
		}

		// Token: 0x0602A9C9 RID: 174537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9C9")]
		[Address(RVA = "0x2650630", Offset = "0x264F230", VA = "0x182650630")]
		public Act20sideCarBlueprintView()
		{
		}

		// Token: 0x0403D5A8 RID: 251304
		[Token(Token = "0x403D5A8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Act20sideCarBlueprintView.BlueprintPosInfo> posList;

		// Token: 0x0403D5A9 RID: 251305
		[Token(Token = "0x403D5A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0403D5AA RID: 251306
		[Token(Token = "0x403D5AA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _selectCircle;

		// Token: 0x0403D5AB RID: 251307
		[Token(Token = "0x403D5AB")]
		[FieldOffset(Offset = "0x30")]
		private Sequence m_sequence;

		// Token: 0x0403D5AC RID: 251308
		[Token(Token = "0x403D5AC")]
		[FieldOffset(Offset = "0x38")]
		private CartComponents.CartAccessoryPos m_cachePos;

		// Token: 0x0403D5AD RID: 251309
		[Token(Token = "0x403D5AD")]
		[FieldOffset(Offset = "0x40")]
		private UIAtlasObject m_atlasObject;

		// Token: 0x0403D5AE RID: 251310
		[Token(Token = "0x403D5AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureAtlasObject;

		// Token: 0x0403D5AF RID: 251311
		[Token(Token = "0x403D5AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403D5B0 RID: 251312
		[Token(Token = "0x403D5B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UnloadCart;

		// Token: 0x0403D5B1 RID: 251313
		[Token(Token = "0x403D5B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetSpriteCart;

		// Token: 0x0403D5B2 RID: 251314
		[Token(Token = "0x403D5B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetPos;

		// Token: 0x0403D5B3 RID: 251315
		[Token(Token = "0x403D5B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTweenSeq;

		// Token: 0x0403D5B4 RID: 251316
		[Token(Token = "0x403D5B4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007654 RID: 30292
		[Token(Token = "0x2007654")]
		[Serializable]
		public class BlueprintPosInfo
		{
			// Token: 0x0602A9CA RID: 174538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A9CA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BlueprintPosInfo()
			{
			}

			// Token: 0x0403D5B5 RID: 251317
			[Token(Token = "0x403D5B5")]
			[FieldOffset(Offset = "0x10")]
			public CartComponents.CartAccessoryPos pos;

			// Token: 0x0403D5B6 RID: 251318
			[Token(Token = "0x403D5B6")]
			[FieldOffset(Offset = "0x18")]
			public UIAtlasImage focusImage;
		}
	}
}
