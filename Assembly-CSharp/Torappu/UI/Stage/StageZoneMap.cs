using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Stage
{
	// Token: 0x0200698B RID: 27019
	[Token(Token = "0x200698B")]
	public class StageZoneMap : MonoBehaviour
	{
		// Token: 0x06026A9A RID: 158362 RVA: 0x000CBF10 File Offset: 0x000CA110
		[Token(Token = "0x6026A9A")]
		[Address(RVA = "0x21C6440", Offset = "0x21C5040", VA = "0x1821C6440")]
		public bool TryAchieveStageButtonTransform(string stageId, out RectTransform transform)
		{
			return default(bool);
		}

		// Token: 0x17005B4C RID: 23372
		// (set) Token: 0x06026A9B RID: 158363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B4C")]
		public Action<string> onStageSelected
		{
			[Token(Token = "0x6026A9B")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x06026A9C RID: 158364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A9C")]
		[Address(RVA = "0x21C5FB0", Offset = "0x21C4BB0", VA = "0x1821C5FB0")]
		public void RenderZone(ZoneViewModel viewModel)
		{
		}

		// Token: 0x06026A9D RID: 158365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A9D")]
		[Address(RVA = "0x21C6350", Offset = "0x21C4F50", VA = "0x1821C6350", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06026A9E RID: 158366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A9E")]
		[Address(RVA = "0x21C5ED0", Offset = "0x21C4AD0", VA = "0x1821C5ED0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06026A9F RID: 158367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A9F")]
		[Address(RVA = "0x5137A0", Offset = "0x5123A0", VA = "0x1805137A0")]
		private void _OnStageSelected(string stageId)
		{
		}

		// Token: 0x06026AA0 RID: 158368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AA0")]
		[Address(RVA = "0x21C6550", Offset = "0x21C5150", VA = "0x1821C6550")]
		private void _TraceForAVG(ZoneViewModel zoneModel)
		{
		}

		// Token: 0x06026AA1 RID: 158369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AA1")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StageZoneMap()
		{
		}

		// Token: 0x0403694F RID: 223567
		[Token(Token = "0x403694F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StageButtonOnMapHolder[] _stageButtons;

		// Token: 0x04036950 RID: 223568
		[Token(Token = "0x4036950")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04036951 RID: 223569
		[Token(Token = "0x4036951")]
		[FieldOffset(Offset = "0x28")]
		private Action<string> m_onStageSelected;

		// Token: 0x04036952 RID: 223570
		[Token(Token = "0x4036952")]
		[FieldOffset(Offset = "0x30")]
		private UIPage m_registeredPage;
	}
}
