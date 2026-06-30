<mxfile host="app.diagrams.net" modified="2026-06-30T00:00:00.000Z" agent="Mozilla/5.0" version="21.0.0" etag="prototype-diagram" type="device">
  <diagram name="Prototype Pattern" id="prototype-diagram">
    <mxGraphModel dx="1434" dy="820" grid="1" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="1" pageScale="1" pageWidth="1200" pageHeight="900" math="0" shadow="0">
      <root>
        <mxCell id="0" />
        <mxCell id="1" parent="0" />

        <!-- ===== Блок Task (абстрактный класс) ===== -->
        <mxCell id="task-class" value="&lt;b&gt;&lt;font style=&quot;font-size: 14px&quot;&gt;Task&lt;/font&gt;&lt;/b&gt;&lt;br&gt;&lt;i&gt;&amp;lt;&amp;lt;abstract&amp;gt;&amp;gt;&lt;/i&gt;&lt;hr&gt;+ Id: int&lt;br&gt;+ Title: string&lt;br&gt;+ Description: string&lt;br&gt;+ DueDate: DateTime&lt;hr&gt;+ Task(title, description, dueDate)&lt;br&gt;&lt;b&gt;+ Clone(): Task*&lt;/b&gt;&lt;br&gt;+ ToString(): string" style="shape=umlClass;fontSize=11;fontFamily=Consolas;html=1;whiteSpace=wrap;verticalAlign=middle;overflow=fill;fillColor=#dae8fc;strokeColor=#6c8ebf;shadow=0;fontStyle=0;align=center;" vertex="1" parent="1">
          <mxGeometry x="400" y="40" width="280" height="190" as="geometry" />
        </mxCell>

        <!-- ===== SimpleTask ===== -->
        <mxCell id="simple-class" value="&lt;b&gt;SimpleTask&lt;/b&gt;&lt;hr&gt;&lt;hr&gt;+ SimpleTask(title, description, dueDate)&lt;br&gt;&lt;b&gt;+ Clone(): Task*&lt;/b&gt;" style="shape=umlClass;fontSize=11;fontFamily=Consolas;html=1;whiteSpace=wrap;verticalAlign=middle;overflow=fill;fillColor=#d5e8d4;strokeColor=#82b366;shadow=0;fontStyle=0;align=center;" vertex="1" parent="1">
          <mxGeometry x="80" y="360" width="250" height="100" as="geometry" />
        </mxCell>

        <!-- ===== Subtask ===== -->
        <mxCell id="subtask-class" value="&lt;b&gt;Subtask&lt;/b&gt;&lt;hr&gt;- ParentTask: Task&lt;hr&gt;+ Subtask(title, description, dueDate, parent)&lt;br&gt;&lt;b&gt;+ Clone(): Task*&lt;/b&gt;" style="shape=umlClass;fontSize=11;fontFamily=Consolas;html=1;whiteSpace=wrap;verticalAlign=middle;overflow=fill;fillColor=#ffe6cc;strokeColor=#d79b00;shadow=0;fontStyle=0;align=center;" vertex="1" parent="1">
          <mxGeometry x="400" y="360" width="280" height="110" as="geometry" />
        </mxCell>

        <!-- ===== RecurringTask ===== -->
        <mxCell id="recurring-class" value="&lt;b&gt;RecurringTask&lt;/b&gt;&lt;hr&gt;+ RepeatIntervalDays: int&lt;br&gt;+ LastExecuted: DateTime&lt;hr&gt;+ RecurringTask(title, description, dueDate, interval)&lt;br&gt;&lt;b&gt;+ Clone(): Task*&lt;/b&gt;" style="shape=umlClass;fontSize=11;fontFamily=Consolas;html=1;whiteSpace=wrap;verticalAlign=middle;overflow=fill;fillColor=#e1d5e7;strokeColor=#9673a6;shadow=0;fontStyle=0;align=center;" vertex="1" parent="1">
          <mxGeometry x="740" y="360" width="280" height="120" as="geometry" />
        </mxCell>

        <!-- ===== Program ===== -->
        <mxCell id="program-class" value="&lt;b&gt;Program&lt;/b&gt;&lt;hr&gt;&lt;hr&gt;+ Main(args): void" style="shape=umlClass;fontSize=11;fontFamily=Consolas;html=1;whiteSpace=wrap;verticalAlign=middle;overflow=fill;fillColor=#f5f5f5;strokeColor=#666666;shadow=0;fontStyle=0;align=center;" vertex="1" parent="1">
          <mxGeometry x="400" y="620" width="280" height="70" as="geometry" />
        </mxCell>

        <!-- ===== Стрелка наследования: Task -> SimpleTask ===== -->
        <mxCell id="inheritance-simple" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=block;endFill=0;strokeWidth=2;strokeColor=#82b366;" edge="1" parent="1" source="task-class" target="simple-class">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- ===== Стрелка наследования: Task -> Subtask ===== -->
        <mxCell id="inheritance-subtask" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=block;endFill=0;strokeWidth=2;strokeColor=#d79b00;" edge="1" parent="1" source="task-class" target="subtask-class">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- ===== Стрелка наследования: Task -> RecurringTask ===== -->
        <mxCell id="inheritance-recurring" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=block;endFill=0;strokeWidth=2;strokeColor=#9673a6;" edge="1" parent="1" source="task-class" target="recurring-class">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>

        <!-- ===== Стрелка агрегации: Subtask -> Task ===== -->
        <mxCell id="aggregation-subtask" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=block;endFill=1;strokeWidth=2;strokeColor=#d79b00;dashed=1;startArrow=diamond;startFill=0;startSize=12;" edge="1" parent="1" source="subtask-class" target="task-class">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="540" y="320" />
              <mxPoint x="540" y="270" />
            </Array>
          </mxGeometry>
        </mxCell>

        <!-- ===== Зависимость: Program -> Task (использует) ===== -->
        <mxCell id="dependency-program" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;endArrow=open;endFill=0;strokeWidth=1.5;strokeColor=#666666;dashed=1;dashPattern=8 4;" edge="1" parent="1" source="program-class" target="task-class">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="540" y="590" />
              <mxPoint x="540" y="230" />
            </Array>
          </mxGeometry>
        </mxCell>

        <!-- ===== Текстовые метки для пояснений ===== -->
        <mxCell id="label-inheritance" value="&lt;b&gt;Наследование&lt;/b&gt;" style="text;html=1;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;fontSize=10;fontColor=#666666;" vertex="1" parent="1">
          <mxGeometry x="260" y="280" width="80" height="20" as="geometry" />
        </mxCell>

        <mxCell id="label-aggregation" value="&lt;b&gt;Агрегация&lt;/b&gt;" style="text;html=1;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;fontSize=10;fontColor=#d79b00;" vertex="1" parent="1">
          <mxGeometry x="610" y="285" width="80" height="20" as="geometry" />
        </mxCell>

        <mxCell id="label-dependency" value="&lt;b&gt;Зависимость&lt;/b&gt;" style="text;html=1;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;fontSize=10;fontColor=#666666;" vertex="1" parent="1">
          <mxGeometry x="600" y="590" width="80" height="20" as="geometry" />
        </mxCell>

        <!-- ===== Заголовок диаграммы ===== -->
        <mxCell id="diagram-title" value="&lt;b&gt;&lt;font style=&quot;font-size: 18px&quot;&gt;Диаграмма классов — Паттерн Prototype&lt;/font&gt;&lt;/b&gt;" style="text;html=1;strokeColor=none;fillColor=none;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;fontSize=14;" vertex="1" parent="1">
          <mxGeometry x="350" y="760" width="500" height="40" as="geometry" />
        </mxCell>

        <!-- ===== Легенда ===== -->
        <mxCell id="legend-box" value="" style="rounded=1;whiteSpace=wrap;html=1;fillColor=#fafafa;strokeColor=#cccccc;dashed=0;" vertex="1" parent="1">
          <mxGeometry x="20" y="20" width="180" height="160" as="geometry" />
        </mxCell>

        <mxCell id="legend-title" value="&lt;b&gt;Условные обозначения&lt;/b&gt;" style="text;html=1;strokeColor=none;fillColor=none;align=left;verticalAlign=middle;whiteSpace=wrap;rounded=0;fontSize=12;fontColor=#333333;" vertex="1" parent="1">
          <mxGeometry x="30" y="28" width="160" height="20" as="geometry" />
        </mxCell>

        <mxCell id="legend-inheritance" value="▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▸&amp;nbsp; Наследование" style="text;html=1;strokeColor=none;fillColor=none;align=left;verticalAlign=middle;whiteSpace=wrap;rounded=0;fontSize=10;fontColor=#333333;" vertex="1" parent="1">
          <mxGeometry x="30" y="58" width="160" height="20" as="geometry" />
        </mxCell>

        <mxCell id="legend-aggregation" value="◇▬▬▬▬▬▬▬▬▬▬▬▬▬▬◆&amp;nbsp; Агрегация" style="text;html=1;strokeColor=none;fillColor=none;align=left;verticalAlign=middle;whiteSpace=wrap;rounded=0;fontSize=10;fontColor=#333333;" vertex="1" parent="1">
          <mxGeometry x="30" y="88" width="160" height="20" as="geometry" />
        </mxCell>

        <mxCell id="legend-dependency" value="- - - - - - - - - - - - -&gt;&amp;nbsp; Зависимость" style="text;html=1;strokeColor=none;fillColor=none;align=left;verticalAlign=middle;whiteSpace=wrap;rounded=0;fontSize=10;fontColor=#333333;" vertex="1" parent="1">
          <mxGeometry x="30" y="118" width="160" height="20" as="geometry" />
        </mxCell>

        <mxCell id="legend-abstract" value="&lt;i&gt;&amp;lt;&amp;lt;abstract&amp;gt;&amp;gt;&lt;/i&gt; — абстрактный класс" style="text;html=1;strokeColor=none;fillColor=none;align=left;verticalAlign=middle;whiteSpace=wrap;rounded=0;fontSize=10;fontColor=#333333;" vertex="1" parent="1">
          <mxGeometry x="30" y="148" width="160" height="20" as="geometry" />
        </mxCell>

      </root>
    </mxGraphModel>
  </diagram>
</mxfile>
            
