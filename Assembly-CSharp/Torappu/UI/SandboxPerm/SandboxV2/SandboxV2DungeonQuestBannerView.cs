using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200423D RID: 16957
	[Token(Token = "0x200423D")]
	public class SandboxV2DungeonQuestBannerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x0601A23A RID: 107066 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A23B RID: 107067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E27")]
		public Action onBannerQuit
		{
			[Token(Token = "0x601A23A")]
			[Address(RVA = "0x1300A40", Offset = "0x12FF640", VA = "0x181300A40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A23B")]
			[Address(RVA = "0x1300AA0", Offset = "0x12FF6A0", VA = "0x181300AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601A23C RID: 107068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A23C")]
		[Address(RVA = "0x1300770", Offset = "0x12FF370", VA = "0x181300770")]
		public void SetParam(SandboxV2DungeonQuestBannerView.Param param)
		{
		}

		// Token: 0x0601A23D RID: 107069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A23D")]
		[Address(RVA = "0x1300500", Offset = "0x12FF100", VA = "0x181300500")]
		public void Render(SandboxV2DungeonQuestBannerView.ViewModel viewModel)
		{
		}

		// Token: 0x0601A23E RID: 107070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A23E")]
		[Address(RVA = "0x13008C0", Offset = "0x12FF4C0", VA = "0x1813008C0")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0601A23F RID: 107071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A23F")]
		[Address(RVA = "0x1300470", Offset = "0x12FF070", VA = "0x181300470")]
		public void PlayQuestStartAudio()
		{
		}

		// Token: 0x0601A240 RID: 107072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A240")]
		[Address(RVA = "0x13003E0", Offset = "0x12FEFE0", VA = "0x1813003E0")]
		public void PlayQuestFailAudio()
		{
		}

		// Token: 0x0601A241 RID: 107073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A241")]
		[Address(RVA = "0x1300350", Offset = "0x12FEF50", VA = "0x181300350")]
		public void PlayQuestCompletedAudio()
		{
		}

		// Token: 0x0601A242 RID: 107074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A242")]
		[Address(RVA = "0x13009E0", Offset = "0x12FF5E0", VA = "0x1813009E0")]
		public SandboxV2DungeonQuestBannerView()
		{
		}

		// Token: 0x04021029 RID: 135209
		[Token(Token = "0x4021029")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _questNameText;

		// Token: 0x0402102A RID: 135210
		[Token(Token = "0x402102A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _questIconImg;

		// Token: 0x0402102B RID: 135211
		[Token(Token = "0x402102B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0402102C RID: 135212
		[Token(Token = "0x402102C")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2DungeonQuestBannerView.Param m_param;

		// Token: 0x0402102E RID: 135214
		[Token(Token = "0x402102E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBannerQuit;

		// Token: 0x0402102F RID: 135215
		[Token(Token = "0x402102F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBannerQuit;

		// Token: 0x04021030 RID: 135216
		[Token(Token = "0x4021030")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetParam;

		// Token: 0x04021031 RID: 135217
		[Token(Token = "0x4021031")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021032 RID: 135218
		[Token(Token = "0x4021032")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04021033 RID: 135219
		[Token(Token = "0x4021033")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayQuestStartAudio;

		// Token: 0x04021034 RID: 135220
		[Token(Token = "0x4021034")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlayQuestFailAudio;

		// Token: 0x04021035 RID: 135221
		[Token(Token = "0x4021035")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayQuestCompletedAudio;

		// Token: 0x04021036 RID: 135222
		[Token(Token = "0x4021036")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200423E RID: 16958
		[Token(Token = "0x200423E")]
		public class Param
		{
			// Token: 0x0601A244 RID: 107076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A244")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04021037 RID: 135223
			[Token(Token = "0x4021037")]
			[FieldOffset(Offset = "0x10")]
			public ListDict<SandboxV2QuestLineBadgeType, SpriteRenderData> questLineIcons;
		}

		// Token: 0x0200423F RID: 16959
		[Token(Token = "0x200423F")]
		public class ViewModel
		{
			// Token: 0x0601A245 RID: 107077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A245")]
			[Address(RVA = "0x1312D90", Offset = "0x1311990", VA = "0x181312D90")]
			public void LoadData(string topicId, bool isRift, string questId)
			{
			}

			// Token: 0x0601A246 RID: 107078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A246")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewModel()
			{
			}

			// Token: 0x04021038 RID: 135224
			[Token(Token = "0x4021038")]
			[FieldOffset(Offset = "0x10")]
			public string questName;

			// Token: 0x04021039 RID: 135225
			[Token(Token = "0x4021039")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2QuestLineBadgeType questLineBadgeType;
		}
	}
}
