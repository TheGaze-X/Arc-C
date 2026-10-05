using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E92 RID: 20114
	[Token(Token = "0x2004E92")]
	public class FireworkCraftZoneBtnItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E02F RID: 122927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E02F")]
		[Address(RVA = "0x17C7550", Offset = "0x17C6150", VA = "0x1817C7550")]
		public void Render(FireworkCraftModel.CraftZoneInfoModel model, string selectedZoneId)
		{
		}

		// Token: 0x0601E030 RID: 122928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E030")]
		[Address(RVA = "0x17C7470", Offset = "0x17C6070", VA = "0x1817C7470")]
		public void OnClick()
		{
		}

		// Token: 0x0601E031 RID: 122929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E031")]
		[Address(RVA = "0x17C7660", Offset = "0x17C6260", VA = "0x1817C7660")]
		public FireworkCraftZoneBtnItem()
		{
		}

		// Token: 0x04027E3D RID: 163389
		[Token(Token = "0x4027E3D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04027E3E RID: 163390
		[Token(Token = "0x4027E3E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnselected;

		// Token: 0x04027E3F RID: 163391
		[Token(Token = "0x4027E3F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x04027E40 RID: 163392
		[Token(Token = "0x4027E40")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027E41 RID: 163393
		[Token(Token = "0x4027E41")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedZoneId;

		// Token: 0x04027E42 RID: 163394
		[Token(Token = "0x4027E42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027E43 RID: 163395
		[Token(Token = "0x4027E43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04027E44 RID: 163396
		[Token(Token = "0x4027E44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
