package application;

import javafx.animation.AnimationTimer;
import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.stage.Stage;

public class DoubleBuferFX extends Application {

    private double velocityX = -2;
    private double velocityY = -2;

    private double locationX=400;
    private double locationY=250;
    private Circle circle;

    private long lastFrame = -1;

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage stage) throws Exception {
        Group root = new Group();
        circle = new Circle(50, Color.BLACK);
        root.getChildren().add(circle);
        circle.setLayoutY(locationX);
        circle.setLayoutX(locationY);
        stage.setScene(new Scene(root, 600, 600));
        stage.show();
        lastFrame = System.nanoTime();
        AnimationTimer timer = new AnimationTimer() {
            @Override
            public void handle(long now) {
                long frameDuration = now - lastFrame;

                circle.setLayoutY(locationX);
                circle.setLayoutX(locationY);


                locationX+=velocityX;
                locationY+=velocityY;
                velocityY=velocityY+.50;
                velocityX*=.999;
                velocityY*=.999;

                if(locationY>500){
                    velocityY=(0-velocityY)*.9;
                    locationY=499;
                }

                if(locationX<00){
                    velocityX=(0-velocityX)*.9;
                    locationX=1;
                }
                if(locationX>500){
                    velocityX=(0-velocityX)*.9;
                    locationX=499;
                }

            }
        };
        timer.start();
    }
}