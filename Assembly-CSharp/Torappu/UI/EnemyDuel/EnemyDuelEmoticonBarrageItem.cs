using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FDB RID: 20443
	[Token(Token = "0x2004FDB")]
	public class EnemyDuelEmoticonBarrageItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E5A6 RID: 124326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5A6")]
		[Address(RVA = "0x18174D0", Offset = "0x18160D0", VA = "0x1818174D0")]
		public void Render(EnemyDuelEmoticonBarrageItem.EmoticonBarrageItemParam param, float laneSamplePos, Action<EnemyDuelEmoticonBarrageItem> onExit)
		{
		}

		// Token: 0x0601E5A7 RID: 124327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5A7")]
		[Address(RVA = "0x18178D0", Offset = "0x18164D0", VA = "0x1818178D0")]
		private void _Render(EnemyDuelEmoticonBarrageItem.EmoticonBarrageItemParam param)
		{
		}

		// Token: 0x0601E5A8 RID: 124328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5A8")]
		[Address(RVA = "0x1817740", Offset = "0x1816340", VA = "0x181817740")]
		private void _RefreshSamplePos()
		{
		}

		// Token: 0x0601E5A9 RID: 124329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5A9")]
		[Address(RVA = "0x1817C60", Offset = "0x1816860", VA = "0x181817C60")]
		public EnemyDuelEmoticonBarrageItem()
		{
		}

		// Token: 0x0402895A RID: 166234
		[Token(Token = "0x402895A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlSelfEmoticon;

		// Token: 0x0402895B RID: 166235
		[Token(Token = "0x402895B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgEmoticon;

		// Token: 0x0402895C RID: 166236
		[Token(Token = "0x402895C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EnemyDuelEmoticonBarrageItem.Coord[] _coords;

		// Token: 0x0402895D RID: 166237
		[Token(Token = "0x402895D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _barrageDuration;

		// Token: 0x0402895E RID: 166238
		[Token(Token = "0x402895E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve _tweenCurve;

		// Token: 0x0402895F RID: 166239
		[Token(Token = "0x402895F")]
		[FieldOffset(Offset = "0x40")]
		private EnemyDuelEmoticonBarrageItem.Coord m_coordTop;

		// Token: 0x04028960 RID: 166240
		[Token(Token = "0x4028960")]
		[FieldOffset(Offset = "0x54")]
		private EnemyDuelEmoticonBarrageItem.Coord m_coordBottom;

		// Token: 0x04028961 RID: 166241
		[Token(Token = "0x4028961")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedEmoticonThemeId;

		// Token: 0x04028962 RID: 166242
		[Token(Token = "0x4028962")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedEmoticonPicId;

		// Token: 0x04028963 RID: 166243
		[Token(Token = "0x4028963")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028964 RID: 166244
		[Token(Token = "0x4028964")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_moveTween;

		// Token: 0x04028965 RID: 166245
		[Token(Token = "0x4028965")]
		[FieldOffset(Offset = "0x90")]
		private float m_samplePos;

		// Token: 0x04028966 RID: 166246
		[Token(Token = "0x4028966")]
		[FieldOffset(Offset = "0x98")]
		private Action<EnemyDuelEmoticonBarrageItem> m_actionOnExit;

		// Token: 0x04028967 RID: 166247
		[Token(Token = "0x4028967")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028968 RID: 166248
		[Token(Token = "0x4028968")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04028969 RID: 166249
		[Token(Token = "0x4028969")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshSamplePos;

		// Token: 0x0402896A RID: 166250
		[Token(Token = "0x402896A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FDC RID: 20444
		[Token(Token = "0x2004FDC")]
		[Serializable]
		private struct Coord
		{
			// Token: 0x0601E5AD RID: 124333 RVA: 0x000AE420 File Offset: 0x000AC620
			[Token(Token = "0x601E5AD")]
			[Address(RVA = "0x180EA10", Offset = "0x180D610", VA = "0x18180EA10")]
			public static EnemyDuelEmoticonBarrageItem.Coord Lerp(EnemyDuelEmoticonBarrageItem.Coord a, EnemyDuelEmoticonBarrageItem.Coord b, float t)
			{
				return default(EnemyDuelEmoticonBarrageItem.Coord);
			}

			// Token: 0x0402896B RID: 166251
			[Token(Token = "0x402896B")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 anchor;

			// Token: 0x0402896C RID: 166252
			[Token(Token = "0x402896C")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 pos;

			// Token: 0x0402896D RID: 166253
			[Token(Token = "0x402896D")]
			[FieldOffset(Offset = "0x10")]
			public float scale;
		}

		// Token: 0x02004FDD RID: 20445
		[Token(Token = "0x2004FDD")]
		public struct EmoticonBarrageItemParam : IHotfixable
		{
			// Token: 0x0601E5AE RID: 124334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E5AE")]
			[Address(RVA = "0x180ED20", Offset = "0x180D920", VA = "0x18180ED20")]
			public void LoadData(EnemyDuelEmojiData param)
			{
			}

			// Token: 0x0402896E RID: 166254
			[Token(Token = "0x402896E")]
			[FieldOffset(Offset = "0x0")]
			public bool isSelf;

			// Token: 0x0402896F RID: 166255
			[Token(Token = "0x402896F")]
			[FieldOffset(Offset = "0x8")]
			public string emoticonThemeId;

			// Token: 0x04028970 RID: 166256
			[Token(Token = "0x4028970")]
			[FieldOffset(Offset = "0x10")]
			public string emoticonPicId;

			// Token: 0x04028971 RID: 166257
			[Token(Token = "0x4028971")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;
		}
	}
}
