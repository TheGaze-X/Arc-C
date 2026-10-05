using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E2C RID: 28204
	[Token(Token = "0x2006E2C")]
	public abstract class ActVecBreakV2EntryZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028243 RID: 164419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028243")]
		[Address(RVA = "0x2371990", Offset = "0x2370590", VA = "0x182371990")]
		public void RenderView(ActVecBreakV2EntryViewModel entryViewModel, ActVecBreakV2ZoneViewModel zoneModel)
		{
		}

		// Token: 0x06028244 RID: 164420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028244")]
		[Address(RVA = "0x2362010", Offset = "0x2360C10", VA = "0x182362010", Slot = "4")]
		protected virtual void OnRender()
		{
		}

		// Token: 0x06028245 RID: 164421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028245")]
		[Address(RVA = "0x2371BD0", Offset = "0x23707D0", VA = "0x182371BD0")]
		protected ActVecBreakV2EntryZoneView()
		{
		}

		// Token: 0x0403900F RID: 233487
		[Token(Token = "0x403900F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _lockPartGO;

		// Token: 0x04039010 RID: 233488
		[Token(Token = "0x4039010")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPartGO;

		// Token: 0x04039011 RID: 233489
		[Token(Token = "0x4039011")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _timeOutMaskGo;

		// Token: 0x04039012 RID: 233490
		[Token(Token = "0x4039012")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _textNameList;

		// Token: 0x04039013 RID: 233491
		[Token(Token = "0x4039013")]
		[FieldOffset(Offset = "0x38")]
		protected UIStateFinder m_stateFinder;

		// Token: 0x04039014 RID: 233492
		[Token(Token = "0x4039014")]
		[FieldOffset(Offset = "0x48")]
		protected ActVecBreakV2EntryViewModel m_entryViewModel;

		// Token: 0x04039015 RID: 233493
		[Token(Token = "0x4039015")]
		[FieldOffset(Offset = "0x50")]
		protected ActVecBreakV2ZoneViewModel m_zoneModel;

		// Token: 0x04039016 RID: 233494
		[Token(Token = "0x4039016")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04039017 RID: 233495
		[Token(Token = "0x4039017")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04039018 RID: 233496
		[Token(Token = "0x4039018")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
