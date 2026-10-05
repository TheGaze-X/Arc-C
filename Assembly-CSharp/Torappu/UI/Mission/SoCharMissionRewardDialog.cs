using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048AB RID: 18603
	[Token(Token = "0x20048AB")]
	public class SoCharMissionRewardDialog : UICompDialog<SoCharMissionRewardDialog.Option>
	{
		// Token: 0x0601C123 RID: 114979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C123")]
		[Address(RVA = "0x1571760", Offset = "0x1570360", VA = "0x181571760", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0601C124 RID: 114980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C124")]
		[Address(RVA = "0x15717C0", Offset = "0x15703C0", VA = "0x1815717C0", Slot = "18")]
		protected override void OnRender(SoCharMissionRewardDialog.Option input)
		{
		}

		// Token: 0x0601C125 RID: 114981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C125")]
		[Address(RVA = "0x15716A0", Offset = "0x15702A0", VA = "0x1815716A0")]
		public void Close()
		{
		}

		// Token: 0x0601C126 RID: 114982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C126")]
		[Address(RVA = "0x1571980", Offset = "0x1570580", VA = "0x181571980")]
		public SoCharMissionRewardDialog()
		{
		}

		// Token: 0x0601C127 RID: 114983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C127")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x04024AAD RID: 150189
		[Token(Token = "0x4024AAD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _start;

		// Token: 0x04024AAE RID: 150190
		[Token(Token = "0x4024AAE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _target;

		// Token: 0x04024AAF RID: 150191
		[Token(Token = "0x4024AAF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ParticleSystem _particle;

		// Token: 0x04024AB0 RID: 150192
		[Token(Token = "0x4024AB0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _durationTime;

		// Token: 0x04024AB1 RID: 150193
		[Token(Token = "0x4024AB1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x04024AB2 RID: 150194
		[Token(Token = "0x4024AB2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04024AB3 RID: 150195
		[Token(Token = "0x4024AB3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Close;

		// Token: 0x04024AB4 RID: 150196
		[Token(Token = "0x4024AB4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048AC RID: 18604
		[Token(Token = "0x20048AC")]
		public class Option
		{
			// Token: 0x0601C128 RID: 114984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C128")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x04024AB5 RID: 150197
			[Token(Token = "0x4024AB5")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 startPos;

			// Token: 0x04024AB6 RID: 150198
			[Token(Token = "0x4024AB6")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 endPos;

			// Token: 0x04024AB7 RID: 150199
			[Token(Token = "0x4024AB7")]
			[FieldOffset(Offset = "0x28")]
			public bool isSingle;
		}
	}
}
