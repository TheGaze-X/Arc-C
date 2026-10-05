using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FA5 RID: 20389
	[Token(Token = "0x2004FA5")]
	public class EnemyDuelEntryAnimHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E4D5 RID: 124117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E4D5")]
		[Address(RVA = "0x17FBA20", Offset = "0x17FA620", VA = "0x1817FBA20")]
		public List<Tween> PlayWithTween()
		{
			return null;
		}

		// Token: 0x0601E4D6 RID: 124118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4D6")]
		[Address(RVA = "0x17FBC60", Offset = "0x17FA860", VA = "0x1817FBC60")]
		public EnemyDuelEntryAnimHolder()
		{
		}

		// Token: 0x04028754 RID: 165716
		[Token(Token = "0x4028754")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation[] _loopAnims;

		// Token: 0x04028755 RID: 165717
		[Token(Token = "0x4028755")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayWithTween;

		// Token: 0x04028756 RID: 165718
		[Token(Token = "0x4028756")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FA6 RID: 20390
		[Token(Token = "0x2004FA6")]
		public struct Builder
		{
			// Token: 0x0601E4D7 RID: 124119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4D7")]
			[Address(RVA = "0x17F8010", Offset = "0x17F6C10", VA = "0x1817F8010")]
			public Builder(string resPath, ILoadAsset assetLoader, RectTransform container)
			{
			}

			// Token: 0x0601E4D8 RID: 124120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E4D8")]
			[Address(RVA = "0x17F7E00", Offset = "0x17F6A00", VA = "0x1817F7E00")]
			public EnemyDuelEntryAnimHolder Create()
			{
				return null;
			}

			// Token: 0x04028757 RID: 165719
			[Token(Token = "0x4028757")]
			[FieldOffset(Offset = "0x0")]
			private string m_resPath;

			// Token: 0x04028758 RID: 165720
			[Token(Token = "0x4028758")]
			[FieldOffset(Offset = "0x8")]
			private ILoadAsset m_assetLoader;

			// Token: 0x04028759 RID: 165721
			[Token(Token = "0x4028759")]
			[FieldOffset(Offset = "0x10")]
			private RectTransform m_container;
		}
	}
}
