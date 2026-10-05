using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Train
{
	// Token: 0x02001C0F RID: 7183
	[Token(Token = "0x2001C0F")]
	public class BuildingTrainingLevelUpSuccessFullView : MonoBehaviour
	{
		// Token: 0x0600B325 RID: 45861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B325")]
		[Address(RVA = "0x32DDD90", Offset = "0x32DC990", VA = "0x1832DDD90")]
		public void Setup(BuildingTrainingLevelUpSuccessFullView.Option option)
		{
		}

		// Token: 0x0600B326 RID: 45862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B326")]
		[Address(RVA = "0x32DE230", Offset = "0x32DCE30", VA = "0x1832DE230")]
		private IEnumerator _MotionCoroutine()
		{
			return null;
		}

		// Token: 0x0600B327 RID: 45863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B327")]
		[Address(RVA = "0x32DE1F0", Offset = "0x32DCDF0", VA = "0x1832DE1F0")]
		public void StopMotion()
		{
		}

		// Token: 0x0600B328 RID: 45864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B328")]
		[Address(RVA = "0x32DDCC0", Offset = "0x32DC8C0", VA = "0x1832DDCC0")]
		public void PlayMotion()
		{
		}

		// Token: 0x0600B329 RID: 45865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B329")]
		[Address(RVA = "0x1A25360", Offset = "0x1A23F60", VA = "0x181A25360")]
		public void HideLevelEffect()
		{
		}

		// Token: 0x0600B32A RID: 45866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B32A")]
		[Address(RVA = "0x32DDC90", Offset = "0x32DC890", VA = "0x1832DDC90")]
		public void OnConfirmButtonClick()
		{
		}

		// Token: 0x0600B32B RID: 45867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B32B")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingTrainingLevelUpSuccessFullView()
		{
		}

		// Token: 0x0400AE48 RID: 44616
		[Token(Token = "0x400AE48")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _charaIllustContainer;

		// Token: 0x0400AE49 RID: 44617
		[Token(Token = "0x400AE49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _skillIconImage;

		// Token: 0x0400AE4A RID: 44618
		[Token(Token = "0x400AE4A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _skillNameText;

		// Token: 0x0400AE4B RID: 44619
		[Token(Token = "0x400AE4B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _skillLevelupHintText;

		// Token: 0x0400AE4C RID: 44620
		[Token(Token = "0x400AE4C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _skillLevelupMiniHintText;

		// Token: 0x0400AE4D RID: 44621
		[Token(Token = "0x400AE4D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _levelPanels;

		// Token: 0x0400AE4E RID: 44622
		[Token(Token = "0x400AE4E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject[] _baseLevelPanel;

		// Token: 0x0400AE4F RID: 44623
		[Token(Token = "0x400AE4F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _levelRootPanel;

		// Token: 0x0400AE50 RID: 44624
		[Token(Token = "0x400AE50")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _phaseHiddenDuration;

		// Token: 0x0400AE51 RID: 44625
		[Token(Token = "0x400AE51")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _phaseMotionDuration;

		// Token: 0x0400AE52 RID: 44626
		[Token(Token = "0x400AE52")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _sfxPositionIntro;

		// Token: 0x0400AE53 RID: 44627
		[Token(Token = "0x400AE53")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _sfxPositionFlash;

		// Token: 0x0400AE54 RID: 44628
		[Token(Token = "0x400AE54")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _miniHintPrefix;

		// Token: 0x0400AE55 RID: 44629
		[Token(Token = "0x400AE55")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string[] _miniHintNumber;

		// Token: 0x0400AE56 RID: 44630
		[Token(Token = "0x400AE56")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _confirmButtonPanel;

		// Token: 0x0400AE57 RID: 44631
		[Token(Token = "0x400AE57")]
		[FieldOffset(Offset = "0x80")]
		private BuildingTrainingLevelUpSuccessFullView.Option m_opt;

		// Token: 0x0400AE58 RID: 44632
		[Token(Token = "0x400AE58")]
		[FieldOffset(Offset = "0x88")]
		private Action m_onConfirm;

		// Token: 0x0400AE59 RID: 44633
		[Token(Token = "0x400AE59")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine m_motionCoroutine;

		// Token: 0x02001C10 RID: 7184
		[Token(Token = "0x2001C10")]
		public class Option
		{
			// Token: 0x0600B32C RID: 45868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B32C")]
			[Address(RVA = "0x32E52C0", Offset = "0x32E3EC0", VA = "0x1832E52C0")]
			public Option()
			{
			}

			// Token: 0x0400AE5A RID: 44634
			[Token(Token = "0x400AE5A")]
			[FieldOffset(Offset = "0x10")]
			public CharUISkinStruct charIllustSkin;

			// Token: 0x0400AE5B RID: 44635
			[Token(Token = "0x400AE5B")]
			[FieldOffset(Offset = "0x28")]
			public Sprite skillIconSprite;

			// Token: 0x0400AE5C RID: 44636
			[Token(Token = "0x400AE5C")]
			[FieldOffset(Offset = "0x30")]
			public string skillName;

			// Token: 0x0400AE5D RID: 44637
			[Token(Token = "0x400AE5D")]
			[FieldOffset(Offset = "0x38")]
			public string skillHintFormat;

			// Token: 0x0400AE5E RID: 44638
			[Token(Token = "0x400AE5E")]
			[FieldOffset(Offset = "0x40")]
			public int specLevel;

			// Token: 0x0400AE5F RID: 44639
			[Token(Token = "0x400AE5F")]
			[FieldOffset(Offset = "0x48")]
			public Action onConfirm;

			// Token: 0x0400AE60 RID: 44640
			[Token(Token = "0x400AE60")]
			[FieldOffset(Offset = "0x50")]
			public int lvlUp;
		}
	}
}
