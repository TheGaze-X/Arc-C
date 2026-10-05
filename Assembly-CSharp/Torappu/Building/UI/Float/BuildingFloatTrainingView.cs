using System;
using Il2CppDummyDll;
using Torappu.Building.UI.Train;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DFB RID: 7675
	[Token(Token = "0x2001DFB")]
	public class BuildingFloatTrainingView : MonoBehaviour
	{
		// Token: 0x0600BD87 RID: 48519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD87")]
		[Address(RVA = "0x33A8210", Offset = "0x33A6E10", VA = "0x1833A8210")]
		private void Update()
		{
		}

		// Token: 0x0600BD88 RID: 48520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD88")]
		[Address(RVA = "0x33A8490", Offset = "0x33A7090", VA = "0x1833A8490")]
		private void _UpdateTrainingStatusWhenTraining()
		{
		}

		// Token: 0x0600BD89 RID: 48521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD89")]
		[Address(RVA = "0x33A8230", Offset = "0x33A6E30", VA = "0x1833A8230")]
		private void _RenderCountDownValue()
		{
		}

		// Token: 0x0600BD8A RID: 48522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD8A")]
		[Address(RVA = "0x33A7D70", Offset = "0x33A6970", VA = "0x1833A7D70")]
		public void InitData()
		{
		}

		// Token: 0x0600BD8B RID: 48523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD8B")]
		[Address(RVA = "0x33A8810", Offset = "0x33A7410", VA = "0x1833A8810")]
		public BuildingFloatTrainingView()
		{
		}

		// Token: 0x0400BE04 RID: 48644
		[Token(Token = "0x400BE04")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _empty;

		// Token: 0x0400BE05 RID: 48645
		[Token(Token = "0x400BE05")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _onTraining;

		// Token: 0x0400BE06 RID: 48646
		[Token(Token = "0x400BE06")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _skillSprite;

		// Token: 0x0400BE07 RID: 48647
		[Token(Token = "0x400BE07")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _startIcon;

		// Token: 0x0400BE08 RID: 48648
		[Token(Token = "0x400BE08")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _targetIcon;

		// Token: 0x0400BE09 RID: 48649
		[Token(Token = "0x400BE09")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FillProgressBar _stateProgress;

		// Token: 0x0400BE0A RID: 48650
		[Token(Token = "0x400BE0A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _stateText;

		// Token: 0x0400BE0B RID: 48651
		[Token(Token = "0x400BE0B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0400BE0C RID: 48652
		[Token(Token = "0x400BE0C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _remainTimeText;

		// Token: 0x0400BE0D RID: 48653
		[Token(Token = "0x400BE0D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _finishPart;

		// Token: 0x0400BE0E RID: 48654
		[Token(Token = "0x400BE0E")]
		[FieldOffset(Offset = "0x68")]
		private CountDownTask m_trainingCountDown;

		// Token: 0x0400BE0F RID: 48655
		[Token(Token = "0x400BE0F")]
		[FieldOffset(Offset = "0x70")]
		private LevelUpSnapshot m_trainSnapshot;

		// Token: 0x0400BE10 RID: 48656
		[Token(Token = "0x400BE10")]
		private const string NAME_FORMAT = "[{0}]{1}";
	}
}
