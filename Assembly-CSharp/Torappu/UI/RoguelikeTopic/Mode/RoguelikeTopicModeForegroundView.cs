using System;
using Il2CppDummyDll;
using Torappu.Scripts.UI.RoguelikeTopic.Mode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Mode
{
	// Token: 0x02004673 RID: 18035
	[Token(Token = "0x2004673")]
	public class RoguelikeTopicModeForegroundView : RoguelikeTopicSubView
	{
		// Token: 0x0601B613 RID: 112147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B613")]
		[Address(RVA = "0x14BC690", Offset = "0x14BB290", VA = "0x1814BC690", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B614 RID: 112148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B614")]
		[Address(RVA = "0x14BC920", Offset = "0x14BB520", VA = "0x1814BC920")]
		private void Update()
		{
		}

		// Token: 0x0601B615 RID: 112149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B615")]
		[Address(RVA = "0x14BC990", Offset = "0x14BB590", VA = "0x1814BC990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B616 RID: 112150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B616")]
		[Address(RVA = "0x14BCBE0", Offset = "0x14BB7E0", VA = "0x1814BCBE0", Slot = "10")]
		protected virtual void _RefreshData(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B617 RID: 112151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B617")]
		[Address(RVA = "0x14BC3D0", Offset = "0x14BAFD0", VA = "0x1814BC3D0")]
		public void EventOnCreateGame()
		{
		}

		// Token: 0x0601B618 RID: 112152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B618")]
		[Address(RVA = "0x14BC1D0", Offset = "0x14BADD0", VA = "0x1814BC1D0")]
		public void EventOnCancelGame()
		{
		}

		// Token: 0x0601B619 RID: 112153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B619")]
		[Address(RVA = "0x14BC2D0", Offset = "0x14BAED0", VA = "0x1814BC2D0")]
		public void EventOnContinueGame()
		{
		}

		// Token: 0x0601B61A RID: 112154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B61A")]
		[Address(RVA = "0x14BCB10", Offset = "0x14BB710", VA = "0x1814BCB10")]
		private void _OnDiffDetailShow()
		{
		}

		// Token: 0x0601B61B RID: 112155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B61B")]
		[Address(RVA = "0x14BD0F0", Offset = "0x14BBCF0", VA = "0x1814BD0F0")]
		public RoguelikeTopicModeForegroundView()
		{
		}

		// Token: 0x0601B61C RID: 112156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B61C")]
		[Address(RVA = "0x14BB4E0", Offset = "0x14BA0E0", VA = "0x1814BB4E0")]
		private void <>xLuaBaseProxy_OnValueChanged(RoguelikeTopicModeViewProperty P0)
		{
		}

		// Token: 0x0402362C RID: 144940
		[Token(Token = "0x402362C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _activePart;

		// Token: 0x0402362D RID: 144941
		[Token(Token = "0x402362D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _zoneName;

		// Token: 0x0402362E RID: 144942
		[Token(Token = "0x402362E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeTopicCurrentDifficultyBaseView _activeDiffView;

		// Token: 0x0402362F RID: 144943
		[Token(Token = "0x402362F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _startTime;

		// Token: 0x04023630 RID: 144944
		[Token(Token = "0x4023630")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _giveUpButton;

		// Token: 0x04023631 RID: 144945
		[Token(Token = "0x4023631")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _unActivePart;

		// Token: 0x04023632 RID: 144946
		[Token(Token = "0x4023632")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _countDownPart;

		// Token: 0x04023633 RID: 144947
		[Token(Token = "0x4023633")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _countDownInfo;

		// Token: 0x04023634 RID: 144948
		[Token(Token = "0x4023634")]
		[FieldOffset(Offset = "0x68")]
		protected RoguelikeTopicModeForegroundPluginContext m_pluginContext;

		// Token: 0x04023635 RID: 144949
		[Token(Token = "0x4023635")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeTopicModeViewProperty m_exploreProp;

		// Token: 0x04023636 RID: 144950
		[Token(Token = "0x4023636")]
		[FieldOffset(Offset = "0x78")]
		private CountDownTask m_cacheCountDownTask;

		// Token: 0x04023637 RID: 144951
		[Token(Token = "0x4023637")]
		[FieldOffset(Offset = "0x80")]
		private string m_topicId;

		// Token: 0x04023638 RID: 144952
		[Token(Token = "0x4023638")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04023639 RID: 144953
		[Token(Token = "0x4023639")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402363A RID: 144954
		[Token(Token = "0x402363A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402363B RID: 144955
		[Token(Token = "0x402363B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402363C RID: 144956
		[Token(Token = "0x402363C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x0402363D RID: 144957
		[Token(Token = "0x402363D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCreateGame;

		// Token: 0x0402363E RID: 144958
		[Token(Token = "0x402363E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnCancelGame;

		// Token: 0x0402363F RID: 144959
		[Token(Token = "0x402363F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnContinueGame;

		// Token: 0x04023640 RID: 144960
		[Token(Token = "0x4023640")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnDiffDetailShow;

		// Token: 0x04023641 RID: 144961
		[Token(Token = "0x4023641")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
