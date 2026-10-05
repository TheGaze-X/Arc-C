using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI.Assist
{
	// Token: 0x02001E03 RID: 7683
	[Token(Token = "0x2001E03")]
	public class AssistAssistantContainer : MonoBehaviour
	{
		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x0600BDBC RID: 48572 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600BDBD RID: 48573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016EE")]
		public Action<int> onAssistSlotClicked
		{
			[Token(Token = "0x600BDBC")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600BDBD")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600BDBE RID: 48574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDBE")]
		[Address(RVA = "0x339ACB0", Offset = "0x33998B0", VA = "0x18339ACB0")]
		public void Render()
		{
		}

		// Token: 0x0600BDBF RID: 48575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDBF")]
		[Address(RVA = "0x339AEE0", Offset = "0x3399AE0", VA = "0x18339AEE0")]
		private void _ReloadAssistViews()
		{
		}

		// Token: 0x0600BDC0 RID: 48576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC0")]
		[Address(RVA = "0x339AEC0", Offset = "0x3399AC0", VA = "0x18339AEC0")]
		private void _OnAssistSlotClicked(int index)
		{
		}

		// Token: 0x0600BDC1 RID: 48577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC1")]
		[Address(RVA = "0x339B190", Offset = "0x3399D90", VA = "0x18339B190")]
		private void _TryRegisterAVGSlots(IList<AssistAssistantView> assistSlots)
		{
		}

		// Token: 0x0600BDC2 RID: 48578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC2")]
		[Address(RVA = "0x339B3B0", Offset = "0x3399FB0", VA = "0x18339B3B0")]
		public AssistAssistantContainer()
		{
		}

		// Token: 0x0400BE54 RID: 48724
		[Token(Token = "0x400BE54")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AssistAssistantView _assistView;

		// Token: 0x0400BE55 RID: 48725
		[Token(Token = "0x400BE55")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] _assistContainer;

		// Token: 0x0400BE56 RID: 48726
		[Token(Token = "0x400BE56")]
		[FieldOffset(Offset = "0x28")]
		private List<AssistAssistantView> m_assistInsts;
	}
}
