using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F84 RID: 24452
	[Token(Token = "0x2005F84")]
	public class CharacterInfoPotentialFullView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005391 RID: 21393
		// (get) Token: 0x0602360A RID: 144906 RVA: 0x000C0AC8 File Offset: 0x000BECC8
		// (set) Token: 0x0602360B RID: 144907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005391")]
		public bool canSkipAnim
		{
			[Token(Token = "0x602360A")]
			[Address(RVA = "0x1E009D0", Offset = "0x1DFF5D0", VA = "0x181E009D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602360B")]
			[Address(RVA = "0x1E00AF0", Offset = "0x1DFF6F0", VA = "0x181E00AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005392 RID: 21394
		// (get) Token: 0x0602360C RID: 144908 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602360D RID: 144909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005392")]
		public Action onClick
		{
			[Token(Token = "0x602360C")]
			[Address(RVA = "0x1E00A30", Offset = "0x1DFF630", VA = "0x181E00A30")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602360D")]
			[Address(RVA = "0x1E00B60", Offset = "0x1DFF760", VA = "0x181E00B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005393 RID: 21395
		// (get) Token: 0x0602360E RID: 144910 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602360F RID: 144911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005393")]
		public UISwitchTween.TweenWrapper tweenWrapper
		{
			[Token(Token = "0x602360E")]
			[Address(RVA = "0x1E00A90", Offset = "0x1DFF690", VA = "0x181E00A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602360F")]
			[Address(RVA = "0x1E00BE0", Offset = "0x1DFF7E0", VA = "0x181E00BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005394 RID: 21396
		// (get) Token: 0x06023610 RID: 144912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005394")]
		public AnimationWrapper animationWrapper
		{
			[Token(Token = "0x6023610")]
			[Address(RVA = "0x1E00970", Offset = "0x1DFF570", VA = "0x181E00970")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023611 RID: 144913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023611")]
		[Address(RVA = "0x1E00160", Offset = "0x1DFED60", VA = "0x181E00160")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData, UIPage page)
		{
		}

		// Token: 0x06023612 RID: 144914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023612")]
		[Address(RVA = "0x1E00750", Offset = "0x1DFF350", VA = "0x181E00750")]
		public IEnumerator ShowAnim()
		{
			return null;
		}

		// Token: 0x06023613 RID: 144915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023613")]
		[Address(RVA = "0x1E00640", Offset = "0x1DFF240", VA = "0x181E00640")]
		public void OnClick()
		{
		}

		// Token: 0x06023614 RID: 144916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023614")]
		[Address(RVA = "0x1E00800", Offset = "0x1DFF400", VA = "0x181E00800")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023615 RID: 144917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023615")]
		[Address(RVA = "0x1E00910", Offset = "0x1DFF510", VA = "0x181E00910")]
		public CharacterInfoPotentialFullView()
		{
		}

		// Token: 0x04030DE4 RID: 200164
		[Token(Token = "0x4030DE4")]
		public const string ANIM_ENTER = "char_potential_full_enter";

		// Token: 0x04030DE5 RID: 200165
		[Token(Token = "0x4030DE5")]
		public const string ANIM_SHOW_KEY = "char_potential_full_show";

		// Token: 0x04030DE6 RID: 200166
		[Token(Token = "0x4030DE6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _illustContainer;

		// Token: 0x04030DE7 RID: 200167
		[Token(Token = "0x4030DE7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _textPotentialContent;

		// Token: 0x04030DE8 RID: 200168
		[Token(Token = "0x4030DE8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCharacter;

		// Token: 0x04030DE9 RID: 200169
		[Token(Token = "0x4030DE9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04030DEA RID: 200170
		[Token(Token = "0x4030DEA")]
		[FieldOffset(Offset = "0x38")]
		private UICharacterIllust m_illust;

		// Token: 0x04030DEB RID: 200171
		[Token(Token = "0x4030DEB")]
		[FieldOffset(Offset = "0x40")]
		private CharacterInfoPotentialFullView.Adapter m_adapter;

		// Token: 0x04030DEC RID: 200172
		[Token(Token = "0x4030DEC")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x04030DF0 RID: 200176
		[Token(Token = "0x4030DF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canSkipAnim;

		// Token: 0x04030DF1 RID: 200177
		[Token(Token = "0x4030DF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_canSkipAnim;

		// Token: 0x04030DF2 RID: 200178
		[Token(Token = "0x4030DF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04030DF3 RID: 200179
		[Token(Token = "0x4030DF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04030DF4 RID: 200180
		[Token(Token = "0x4030DF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tweenWrapper;

		// Token: 0x04030DF5 RID: 200181
		[Token(Token = "0x4030DF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_tweenWrapper;

		// Token: 0x04030DF6 RID: 200182
		[Token(Token = "0x4030DF6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_animationWrapper;

		// Token: 0x04030DF7 RID: 200183
		[Token(Token = "0x4030DF7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030DF8 RID: 200184
		[Token(Token = "0x4030DF8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowAnim;

		// Token: 0x04030DF9 RID: 200185
		[Token(Token = "0x4030DF9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04030DFA RID: 200186
		[Token(Token = "0x4030DFA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030DFB RID: 200187
		[Token(Token = "0x4030DFB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F85 RID: 24453
		[Token(Token = "0x2005F85")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005395 RID: 21397
			// (get) Token: 0x06023616 RID: 144918 RVA: 0x000C0AE0 File Offset: 0x000BECE0
			[Token(Token = "0x17005395")]
			public override int count
			{
				[Token(Token = "0x6023616")]
				[Address(RVA = "0x1DFDEE0", Offset = "0x1DFCAE0", VA = "0x181DFDEE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17005396 RID: 21398
			// (get) Token: 0x06023617 RID: 144919 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06023618 RID: 144920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005396")]
			public CharacterData.PotentialRank[] dataSet
			{
				[Token(Token = "0x6023617")]
				[Address(RVA = "0x1DFE100", Offset = "0x1DFCD00", VA = "0x181DFE100")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6023618")]
				[Address(RVA = "0x1DFE160", Offset = "0x1DFCD60", VA = "0x181DFE160")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06023619 RID: 144921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023619")]
			[Address(RVA = "0x1DFD8B0", Offset = "0x1DFC4B0", VA = "0x181DFD8B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602361A RID: 144922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602361A")]
			[Address(RVA = "0x1DFDC70", Offset = "0x1DFC870", VA = "0x181DFDC70")]
			public Adapter()
			{
			}

			// Token: 0x04030DFD RID: 200189
			[Token(Token = "0x4030DFD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030DFE RID: 200190
			[Token(Token = "0x4030DFE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04030DFF RID: 200191
			[Token(Token = "0x4030DFF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x04030E00 RID: 200192
			[Token(Token = "0x4030E00")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04030E01 RID: 200193
			[Token(Token = "0x4030E01")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
