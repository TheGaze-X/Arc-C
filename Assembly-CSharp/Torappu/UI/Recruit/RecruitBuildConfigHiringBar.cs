using System;
using Il2CppDummyDll;
using Torappu.Building.UI.Float;
using Torappu.Building.UI.Hire;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004733 RID: 18227
	[Token(Token = "0x2004733")]
	public class RecruitBuildConfigHiringBar : MonoBehaviour
	{
		// Token: 0x0601BA07 RID: 113159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA07")]
		[Address(RVA = "0x14F6A70", Offset = "0x14F5670", VA = "0x1814F6A70")]
		public void OnBind()
		{
		}

		// Token: 0x0601BA08 RID: 113160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA08")]
		[Address(RVA = "0x14F6B60", Offset = "0x14F5760", VA = "0x1814F6B60")]
		private void Update()
		{
		}

		// Token: 0x0601BA09 RID: 113161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA09")]
		[Address(RVA = "0x14F65C0", Offset = "0x14F51C0", VA = "0x1814F65C0")]
		public void Init(object objUseless)
		{
		}

		// Token: 0x0601BA0A RID: 113162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA0A")]
		[Address(RVA = "0x14F6B80", Offset = "0x14F5780", VA = "0x1814F6B80")]
		private void _RefreshState()
		{
		}

		// Token: 0x0601BA0B RID: 113163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA0B")]
		[Address(RVA = "0x14F6CB0", Offset = "0x14F58B0", VA = "0x1814F6CB0")]
		public RecruitBuildConfigHiringBar()
		{
		}

		// Token: 0x04023D24 RID: 146724
		[Token(Token = "0x4023D24")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x04023D25 RID: 146725
		[Token(Token = "0x4023D25")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textEmpty;

		// Token: 0x04023D26 RID: 146726
		[Token(Token = "0x4023D26")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _hiringObj;

		// Token: 0x04023D27 RID: 146727
		[Token(Token = "0x4023D27")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _hiredObj;

		// Token: 0x04023D28 RID: 146728
		[Token(Token = "0x4023D28")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _hireProgress;

		// Token: 0x04023D29 RID: 146729
		[Token(Token = "0x4023D29")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _timeCountDown;

		// Token: 0x04023D2A RID: 146730
		[Token(Token = "0x4023D2A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _hireState;

		// Token: 0x04023D2B RID: 146731
		[Token(Token = "0x4023D2B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingHireRefreshCountView _refreshCount;

		// Token: 0x04023D2C RID: 146732
		[Token(Token = "0x4023D2C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textFinish;

		// Token: 0x04023D2D RID: 146733
		[Token(Token = "0x4023D2D")]
		[FieldOffset(Offset = "0x60")]
		private CountDownTask m_hiringCountDown;

		// Token: 0x04023D2E RID: 146734
		[Token(Token = "0x4023D2E")]
		[FieldOffset(Offset = "0x68")]
		private HiringSnapshot m_hireSnapshot;
	}
}
