using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.I18N
{
	// Token: 0x02001623 RID: 5667
	[Token(Token = "0x2001623")]
	[RequireComponent(typeof(Text))]
	[ExecuteInEditMode]
	public class LocalizeTextBestFit : MonoBehaviour, IHotfixable, ILayoutSelfController, ILayoutController
	{
		// Token: 0x060080A3 RID: 32931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A3")]
		[Address(RVA = "0x2888880", Offset = "0x2887480", VA = "0x182888880")]
		private void Awake()
		{
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A4")]
		[Address(RVA = "0x2888930", Offset = "0x2887530", VA = "0x182888930")]
		private void CacheComponents()
		{
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A5")]
		[Address(RVA = "0x2888CE0", Offset = "0x28878E0", VA = "0x182888CE0")]
		private void CacheDefaults()
		{
		}

		// Token: 0x060080A6 RID: 32934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A6")]
		[Address(RVA = "0x2888FC0", Offset = "0x2887BC0", VA = "0x182888FC0")]
		private void InitializeFlags()
		{
		}

		// Token: 0x060080A7 RID: 32935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A7")]
		[Address(RVA = "0x2889030", Offset = "0x2887C30", VA = "0x182889030")]
		private void OnValidate()
		{
		}

		// Token: 0x060080A8 RID: 32936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A8")]
		[Address(RVA = "0x2889360", Offset = "0x2887F60", VA = "0x182889360", Slot = "4")]
		public void SetLayoutHorizontal()
		{
		}

		// Token: 0x060080A9 RID: 32937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080A9")]
		[Address(RVA = "0x28893C0", Offset = "0x2887FC0", VA = "0x1828893C0", Slot = "5")]
		public void SetLayoutVertical()
		{
		}

		// Token: 0x060080AA RID: 32938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080AA")]
		[Address(RVA = "0x2888220", Offset = "0x2886E20", VA = "0x182888220")]
		private void ApplyBestFit()
		{
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080AB")]
		[Address(RVA = "0x2888530", Offset = "0x2887130", VA = "0x182888530")]
		private void ApplyParentWidthConstraint()
		{
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080AC")]
		[Address(RVA = "0x28886F0", Offset = "0x28872F0", VA = "0x1828886F0")]
		private void ApplySelfWidthConstraint()
		{
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60080AD")]
		[Address(RVA = "0x2888EA0", Offset = "0x2887AA0", VA = "0x182888EA0")]
		private Transform FindParentWithContentSizeFitter(Transform child)
		{
			return null;
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080AE")]
		[Address(RVA = "0x2889190", Offset = "0x2887D90", VA = "0x182889190")]
		private void RestoreDefaults()
		{
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080AF")]
		[Address(RVA = "0x2889420", Offset = "0x2888020", VA = "0x182889420")]
		public LocalizeTextBestFit()
		{
		}

		// Token: 0x040081DB RID: 33243
		[Token(Token = "0x40081DB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("在Editor中开启调试模式，用于预览效果")]
		private bool _preview;

		// Token: 0x040081DC RID: 33244
		[Token(Token = "0x40081DC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("处理text本身，自身width到达maxWidth后text变为bestfit，当有嵌套的父节点layout拥有consizeFitter时使用另一项parentWidth控制，默认填写0即可")]
		private int _maxWidth;

		// Token: 0x040081DD RID: 33245
		[Token(Token = "0x40081DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("当有嵌套的父节点layout拥有consizeFitter时，控制最近的拥有ContentSizeFitter父节点的最大width值，需要注意子节点text的wrap适配")]
		private int _maxParentWidth;

		// Token: 0x040081DE RID: 33246
		[Token(Token = "0x40081DE")]
		[FieldOffset(Offset = "0x28")]
		private Text text;

		// Token: 0x040081DF RID: 33247
		[Token(Token = "0x40081DF")]
		[FieldOffset(Offset = "0x30")]
		private ContentSizeFitter contentSizeFitter;

		// Token: 0x040081E0 RID: 33248
		[Token(Token = "0x40081E0")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform rectTransform;

		// Token: 0x040081E1 RID: 33249
		[Token(Token = "0x40081E1")]
		[FieldOffset(Offset = "0x40")]
		private Transform sizeFitterParent;

		// Token: 0x040081E2 RID: 33250
		[Token(Token = "0x40081E2")]
		[FieldOffset(Offset = "0x48")]
		private HorizontalLayoutGroup layoutParent;

		// Token: 0x040081E3 RID: 33251
		[Token(Token = "0x40081E3")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform layoutParentRect;

		// Token: 0x040081E4 RID: 33252
		[Token(Token = "0x40081E4")]
		[FieldOffset(Offset = "0x58")]
		private ContentSizeFitter parentContentSizeFitter;

		// Token: 0x040081E5 RID: 33253
		[Token(Token = "0x40081E5")]
		[FieldOffset(Offset = "0x60")]
		private ContentSizeFitter.FitMode defaultFitMode;

		// Token: 0x040081E6 RID: 33254
		[Token(Token = "0x40081E6")]
		[FieldOffset(Offset = "0x64")]
		private bool defaultTextForBestFit;

		// Token: 0x040081E7 RID: 33255
		[Token(Token = "0x40081E7")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 defaultParentSize;

		// Token: 0x040081E8 RID: 33256
		[Token(Token = "0x40081E8")]
		[FieldOffset(Offset = "0x70")]
		private ContentSizeFitter.FitMode defaultParentFitMode;

		// Token: 0x040081E9 RID: 33257
		[Token(Token = "0x40081E9")]
		[FieldOffset(Offset = "0x74")]
		private bool defaultLayoutParentChildMode;

		// Token: 0x040081EA RID: 33258
		[Token(Token = "0x40081EA")]
		[FieldOffset(Offset = "0x78")]
		private string lastText;

		// Token: 0x040081EB RID: 33259
		[Token(Token = "0x40081EB")]
		[FieldOffset(Offset = "0x80")]
		private bool hasMaxWidth;

		// Token: 0x040081EC RID: 33260
		[Token(Token = "0x40081EC")]
		[FieldOffset(Offset = "0x81")]
		private bool hasMaxParentWidth;

		// Token: 0x040081ED RID: 33261
		[Token(Token = "0x40081ED")]
		[FieldOffset(Offset = "0x84")]
		private Vector2 tempVector2;

		// Token: 0x040081EE RID: 33262
		[Token(Token = "0x40081EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040081EF RID: 33263
		[Token(Token = "0x40081EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CacheComponents;

		// Token: 0x040081F0 RID: 33264
		[Token(Token = "0x40081F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CacheDefaults;

		// Token: 0x040081F1 RID: 33265
		[Token(Token = "0x40081F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitializeFlags;

		// Token: 0x040081F2 RID: 33266
		[Token(Token = "0x40081F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValidate;

		// Token: 0x040081F3 RID: 33267
		[Token(Token = "0x40081F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetLayoutHorizontal;

		// Token: 0x040081F4 RID: 33268
		[Token(Token = "0x40081F4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetLayoutVertical;

		// Token: 0x040081F5 RID: 33269
		[Token(Token = "0x40081F5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ApplyBestFit;

		// Token: 0x040081F6 RID: 33270
		[Token(Token = "0x40081F6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ApplyParentWidthConstraint;

		// Token: 0x040081F7 RID: 33271
		[Token(Token = "0x40081F7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplySelfWidthConstraint;

		// Token: 0x040081F8 RID: 33272
		[Token(Token = "0x40081F8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_FindParentWithContentSizeFitter;

		// Token: 0x040081F9 RID: 33273
		[Token(Token = "0x40081F9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RestoreDefaults;

		// Token: 0x040081FA RID: 33274
		[Token(Token = "0x40081FA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
