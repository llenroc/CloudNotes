﻿//  =======================================================================================================
// 
//     ,uEZGZX  LG                             Eu       iJ       vi                                              
//    BB7.  .:  uM                             8F       0BN      Bq             S:                               
//   @X         LO    rJLYi    :     i    iYLL XJ       Xu7@     Mu    7LjL;   rBOii   7LJ7    .vYUi             
//  ,@          LG  7Br...SB  vB     B   B1...7BL       0S i@,   OU  :@7. ,u@   @u.. :@:  ;B  LB. ::             
//  v@          LO  B      Z0 i@     @  BU     @Y       qq  .@L  Oj  @      5@  Oi   @.    MB U@                 
//  .@          JZ :@      :@ rB     B  @      5U       Eq    @0 Xj ,B      .B  Br  ,B:rv777i  :0ZU              
//   @M         LO  @      Mk :@    .@  BL     @J       EZ     GZML  @      XM  B;   @            Y@             
//    ZBFi::vu  1B  ;B7..:qO   BS..iGB   BJ..:vB2       BM      rBj  :@7,.:5B   qM.. i@r..i5. ir. UB             
//      iuU1vi   ,    ;LLv,     iYvi ,    ;LLr  .       .,       .     rvY7:     rLi   7LLr,  ,uvv:  
// 
// 
//  Copyright 2014-2015 daxnet
//  
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  
//      http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  =======================================================================================================

namespace YARTE.Buttons
{
    using System.Drawing;
    using mshtml;
    using YARTE.Properties;
    using YARTE.UI.Buttons;

    public class InsertHtmlWithParameterButton : IHTMLEditorButton
    {
        private readonly string html;

        public InsertHtmlWithParameterButton(string html)
        {
            this.html = html;
        }

        #region IHTMLEditorButton Members

        public void IconClicked(HTMLEditorButtonArgs doc)
        {
            // Use the DOM objects to manipulate the HTML document to insert HTML.
            // 'insertHTML' command in execCommand interface is not supported.
            IHTMLDocument2 d2 = doc.Document.DomDocument as IHTMLDocument2;
            if (d2 != null)
            {
                var range = d2.selection.createRange() as IHTMLTxtRange;
                if (range != null)
                {
                    range.pasteHTML(this.html);
                }
            }
        }

        public Image IconImage
        {
            get { return Resources.page_white_world; }
        }

        public string IconName
        {
            get { return "Insert html"; }
        }

        public string IconTooltip
        {
            get { return Resources.InsertHtmlToolTip; }
        }

        public string CommandIdentifier
        {
            get { return ""; }
        }

        #endregion
    }
}